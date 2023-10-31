using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.EntityData;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Validators;
using CorazonDeCafeStockManager.App.Views.OrderForm;
using CorazonDeCafeStockManager.utils.Custom.TextBox;
using FluentValidation.Results;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class OrderPresenter
    {
        private readonly HomePresenter homePresenter;
        private readonly IOrderView view;
        private readonly IBillingRepository billingRepository;

        private bool isInactive = false;

        public OrderPresenter(IOrderView view, IBillingRepository billingRepository, Order Order, HomePresenter homePresenter)
        {
            this.view = view;
            this.homePresenter = homePresenter;
            this.billingRepository = billingRepository;
            this.view.SaveEvent += SaveEvent!;
            this.view.CancelEvent += CancelEvent!;

            if (Order != null) SetOrderToView(Order);
        }

        private void SetOrderToView(Order Order)
        {
            view.OrderId = Order.Id;
            view.OrderCustomerName = Order.Customer!.User.Name;
            view.OrderCustomerSurname = Order.Customer.User.Surname;
            view.OrderEmployeeName = Order.Employee!.User.Name + " " + Order.Employee.User.Surname;
            view.OrderCustomerDNI = Order.Customer.User.Dni;
            view.OrderBillingType = Order.BillingType.Description;
            view.OrderPaymentMethod = Order.PaymentMethod.Description;
            view.OrderTotal = Order.TotalPrice.ToString("0.00");
            view.OrderStatus!.Texts = Order.Status == 1 ? "activo" : "inactivo";
            view.Title = Order.CreatedAt.ToString()!.ToUpper();

            if (Order.Status == 0)
            {
                view.OrderStatus.Enabled = false;
                isInactive = true;
            }
        }
        public void CloseView()
        {
            view.Close();
        }
        private async void SaveEvent(object sender, EventArgs e)
        {
            try
            {
                if (!isInactive) await billingRepository.DeleteBilling((int)view.OrderId!);
                homePresenter.ShowOrdersView(this, EventArgs.Empty);
                view.Close();
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
                return;
            }
        }

        private async void CancelEvent(object sender, EventArgs e)
        {
            Order Order = await billingRepository.GetBillingById((int)view.OrderId!);

            if (Order.Status != (view.OrderStatus!.Texts == "activo" ? 1 : 0))
            {
                DialogResult dialogResult = MessageBox.Show("Hay cambios sin guardar, ¿Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            homePresenter.ShowOrdersView(this, EventArgs.Empty);
            view.Close();
            return;
        }
    }
}