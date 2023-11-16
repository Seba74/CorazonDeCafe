using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.EntityData;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Views.BillingForm;
using CorazonDeCafeStockManager.App.Views.PrintedBillingForm;
using CorazonDeCafeStockManager.utils.Custom.TextBox;
using Microsoft.IdentityModel.Tokens;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class BillingPresenter
    {
        private readonly IBillingView view;
        private readonly IBillingRepository billingRepository;
        private readonly ICustomerRepository customerRepository;
        private readonly ProductsPresenter productsPresenter;
        private readonly HomePresenter homePresenter;
        private IEnumerable<Customer>? customers;
        public BillingPresenter(IBillingView view, IBillingRepository billingRepository,
        ICustomerRepository customerRepository, ProductsPresenter productsPresenter,
        HomePresenter homePresenter, Customer customer)
        {
            this.view = view;
            this.homePresenter = homePresenter;
            this.billingRepository = billingRepository;
            this.customerRepository = customerRepository;
            this.productsPresenter = productsPresenter;

            this.view.BtnCustomerEvent += BtnCustomerEvent!;
            this.view.LookForCustomer += LookForCustomer!;
            this.view.OrderTypeEvent += OrderTypeEvent!;
            this.view.ValidateEvent += ValidateEvent!;

            this.view.AmountChangedEvent += AmountChangedEvent!;
            this.view.RemoveProductEvent += RemoveProductEvent!;
            this.view.ValidateAmountEvent += ValidateAmountEvent!;

            this.view.SaveOrderEvent += SaveOrderEvent!;
            this.view.CancelOrderEvent += CancelOrderEvent!;

            this.productsPresenter.AddProductToCartEvent += AddProductToCartEvent!;

            this.productsPresenter.RemoveColumnFromDataGrid(6);

            if (Cart.Order != null)
            {
                UpdateData();
            }

            if (customer == null && Cart.Customer != null) SetCustomer(Cart.Customer);
            else if (customer != null) SetCustomer(customer);

            _ = Task.Run(() => LoadCustomer());

            LoadBillingInfo();
            this.view.Show();

        }

        public async Task LoadCustomer()
        {
            customers = await customerRepository.GetAllCustomers();
        }

        private void LoadBillingInfo()
        {
            view.PaymentMethod!.Items.AddRange(LocalStorage.PaymentMethods!.Select(pm => pm.Description).ToArray());
            view.PaymentMethod!.Texts = LocalStorage.PaymentMethods!.FirstOrDefault(pm => pm.Id == 1)!.Description;

            view.BillingType!.Items.AddRange(LocalStorage.BillingTypes!.Select(bt => bt.Description).ToArray());
            view.BillingType!.Texts = LocalStorage.BillingTypes!.FirstOrDefault(bt => bt.Id == 2)!.Description;
        }

        private void UpdateData()
        {
            view.OrderSubtotal = Cart.Order!.Subtotal.ToString("0.00");
            view.OrderIva = Cart.Order!.Iva.ToString("0.00");
            view.OrderTotal = Cart.Order!.TotalPrice.ToString("0.00");
            view.CartList = Cart.Order.Products;
            view.LoadProducts();
        }

        private void LookForCustomer(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(view.SearchCustomer))
            {
                Customer? customer = customers!.FirstOrDefault(c => c.User.Dni == view.SearchCustomer);
                if (customer != null)
                {
                    SetCustomer(customer);
                }
                else
                {
                    view.CustomerName = string.Empty;
                    view.CustomerAddress = string.Empty;
                    view.CustomerContact = string.Empty;
                }
            }
        }
        public void AddProductToCartEvent(object sender, EventArgs e)
        {
            Product product = (Product)sender;
            OrderProductData orderProductData = new()
            {
                ProductId = product.Id,
                Product = product,
                Amount = 1,
                Stock = product.Stock,
                Price = product.Price
            };

            OrderProductData? order = Cart.Order?.Products?.FirstOrDefault(o => o.ProductId == orderProductData.ProductId);
            if (order?.Amount + 1 > order?.Stock)
            {
                view.ShowError("No hay suficiente stock");
                return;
            }

            Cart.AddProductToCart(orderProductData);
            UpdateData();
        }
        private void SetCustomer(Customer customer)
        {
            view.CustomerName = customer.User.Name.ToUpper() + " " + customer.User.Surname.ToUpper();
            view.CustomerAddress = customer.User.Address!.Street.ToUpper() + " " + customer.User.Address.Number;
            view.CustomerContact = customer.User.Phone!.ToUpper();
            Cart.Customer = customer;
        }

        private async void SaveOrderEvent(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(view.BillingType!.Texts))
            {
                view.ShowError("Debe seleccionar un tipo de factura");
                return;
            }

            if (string.IsNullOrEmpty(view.PaymentMethod!.Texts))
            {
                view.ShowError("Debe seleccionar un método de pago");
                return;
            }

            if (Cart.Order == null)
            {
                view.ShowError("No hay productos seleccionados");
                return;
            }

            if (view.BillingType!.Texts == LocalStorage.BillingTypes!.FirstOrDefault(bt => bt.Id == 1)!.Description && string.IsNullOrEmpty(view.CustomerCUIT?.Texts))
            {
                view.ShowError("Debe ingresar el CUIT del cliente");
                return;
            }

            if (Cart.Customer == null)
            {
                view.ShowError("Debe seleccionar un cliente");
                return;
            }

            try
            {
                Cart.Order!.CustomerId = Cart.Customer.Id;
                Cart.Order.CustomerCuit = view.CustomerCUIT?.Texts;
                Cart.Order.BillingType = LocalStorage.BillingTypes!.FirstOrDefault(bt => bt.Description == view.BillingType.Texts)!.Id;
                Cart.Order.PaymentMethod = LocalStorage.PaymentMethods!.FirstOrDefault(pm => pm.Description == view.PaymentMethod!.Texts)!.Id;
                Cart.Order.Status = 1;

                await billingRepository.AddBilling(Cart.Order);
                
                Order savedOrder = await billingRepository.GetLastBilling();

                PrintedBillingForm printedBillingForm = new();
                printedBillingForm.SetDataToPrintedBillingForm(savedOrder);

                Cart.ClearCart();
                ResetData();

                LocalStorage.Orders = null;

                homePresenter.SetPrintedBilling(printedBillingForm);
                homePresenter.ShowPrintedBilling();
            }
            catch (Exception exception)
            {
                view.ShowError(exception.Message);
            }
        }

        private void ResetData()
        {
            view.CustomerName = string.Empty;
            view.CustomerAddress = string.Empty;
            view.CustomerContact = string.Empty;
            view.CustomerCUIT!.Texts = string.Empty;
            view.BillingType!.Texts = LocalStorage.BillingTypes!.FirstOrDefault(bt => bt.Id == 2)!.Description;
            view.PaymentMethod!.Texts = LocalStorage.PaymentMethods!.FirstOrDefault(pm => pm.Id == 1)!.Description;

            view.OrderSubtotal = "0.00";
            view.OrderIva = "0.00";
            view.OrderTotal = "0.00";

            view.CartList = new List<OrderProductData>();
            view.LoadProducts();
        }

        private void CancelOrderEvent(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea cancelar la venta?", "Cancelar venta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Cart.ClearCart();
                homePresenter.ShowHomeView();
                view.Close();
            }
        }

        private void AmountChangedEvent(object sender, DataGridViewCellEventArgs e)
        {
            int amountIndex = 3;

            if (e.ColumnIndex == amountIndex)
            {
                Object amountObject = view.Cart.Rows[e.RowIndex].Cells[amountIndex].Value;
                int amount = amountObject != null ? Convert.ToInt32(amountObject) : 0;

                int productId = (int)view.Cart.Rows[e.RowIndex].Cells[0].Value;
                OrderProductData orderProductData = Cart.Order?.Products!.FirstOrDefault(op => op.ProductId == productId)!;

                if (amount > orderProductData.Stock)
                {
                    amount = orderProductData.Amount;
                    view.Cart.Rows[e.RowIndex].Cells[amountIndex].Value = amount;
                    view.ShowError("No hay suficiente stock");
                }
                else
                {
                    Cart.UpdateProductFromCart(orderProductData, amount);
                    UpdateData();
                }
            }
        }

        private void RemoveProductEvent(object sender, DataGridViewCellEventArgs e)
        {
            int removeIndex = 4;

            if (e.ColumnIndex == removeIndex)
            {
                int productId = (int)view.Cart.Rows[e.RowIndex].Cells[0].Value;
                OrderProductData orderProductData = Cart.Order?.Products!.FirstOrDefault(op => op.ProductId == productId)!;

                Cart.RemoveProductFromCart(orderProductData);
                UpdateData();
            }
        }

        private void ValidateAmountEvent(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int amountIndex = 3;

            if (view.Cart.CurrentCell.ColumnIndex == amountIndex)
            {
                if (e.Control is TextBox textBox)
                {
                    textBox.KeyPress -= new KeyPressEventHandler(ValidateIntArg!);
                    textBox.KeyPress += new KeyPressEventHandler(ValidateIntArg!);
                }
            }
        }

        private void ValidateIntArg(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ValidateEvent(object sender, KeyPressEventArgs e)
        {
            TextBoxCustom textBox = (TextBoxCustom)sender;

            if (e.KeyChar == '\b')
            {
                return;
            }

            if (!IsValidInput(e.KeyChar, textBox))
            {
                e.Handled = true;
            }
        }

        private bool IsValidInput(char inputChar, TextBoxCustom textBox)
        {
            return textBox.Name switch
            {
                "ipSearch" => char.IsDigit(inputChar) && IsIntValid(textBox.Texts + inputChar),
                "ipCUIT" => char.IsDigit(inputChar) && IsIntValid(textBox.Texts + inputChar),
                _ => true,
            };
        }

        private bool IsIntValid(string inputText)
        {
            if (!string.IsNullOrWhiteSpace(inputText) && long.TryParse(inputText, out long number))
            {
                return number >= 0;
            }
            return false;
        }

        private void OrderTypeEvent(object sender, EventArgs e)
        {
            if (view.BillingType!.Texts == "Factura A") view.CustomerCUIT!.Enabled = true;
            else view.CustomerCUIT!.Enabled = false;
        }

        private void BtnCustomerEvent(object sender, EventArgs e)
        {
            homePresenter.ShowCustomersView(sender, e);
        }

        public void ShowView() => view.Show();
        public void CloseView() => view.Close();
    }
}
