using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Views.OrdersForm;
using CorazonDeCafeStockManager.App.Views.PrintedBillingForm;
using Timer = System.Timers.Timer;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class OrdersPresenter
    {
        private readonly Timer SearchTimer = new(1200);
        private readonly IOrdersView view;
        private readonly HomePresenter homePresenter;
        private readonly IBillingRepository billingRepository;
        private IEnumerable<Order>? orders;
        private IEnumerable<Order>? ordersBackup;
        private string previousSearchText = string.Empty;
        public OrdersPresenter(IOrdersView view, IBillingRepository billingRepository, HomePresenter homePresenter)
        {
            this.view = view;
            this.homePresenter = homePresenter;
            this.billingRepository = billingRepository;

            this.view.SearchEvent += SearchEvent!;
            this.view.FilterEvent += FilterEvent!;
            this.view.ResetOrdersEvent += ResetOrdersEvent!;
            this.view.ShowOrderDetailsEvent += ShowOrderDetailsEvent!;
            this.view.EditEvent += EditEvent!;

            _ = LoadAllOrders();

            SearchTimer.Elapsed += SearchOrders!;


            this.view.Show();
        }
        public async Task LoadAllOrders()
        {
            try
            {
                    orders = await billingRepository.GetAllBillings();

                    if (SessionManager.RoleId == 4)
                    {
                        orders = orders.Where(o => o.EmployeeId == SessionManager.Id);
                    }

                    ordersBackup = orders;
                    view.OrdersList = orders;
                    view.LoadOrders();
                    view.SelectedPaymentMethod.Items.Add("Todos");
                    view.SelectedPaymentMethod.Items.AddRange(LocalStorage.PaymentMethods!.Select(pm => pm.Description).ToArray());

                    view.SelectedBillingType.Items.Add("Todos");
                    view.SelectedBillingType.Items.AddRange(LocalStorage.BillingTypes!.Select(bt => bt.Description).ToArray());
            }
            catch (Exception e)
            {
                view.ShowError(e.Message);
            }
        }

        public void ShowView() => view.Show();
        public void CloseView() => view.Close();

        private void SearchOrders(object sender, EventArgs e)
        {
            SearchTimer.Stop();
            if (!string.IsNullOrEmpty(view.Search))
            {
                if (int.TryParse(view.Search, out int id))
                {
                    view.OrdersList = orders?.Where(o => o.Id == id);
                }
                else
                {
                    view.OrdersList = orders?.Where(o => (o.Customer!.User.Name + " " + o.Customer.User.Surname).ToLowerInvariant().Contains(view.Search!.ToLowerInvariant()));
                }
            }
            else
            {
                view.OrdersList = orders;
            }
            view.LoadOrders();
        }


        private void ResetOrdersEvent(object sender, EventArgs e)
        {
            view.Search = string.Empty;

            view.SelectedPaymentMethod.Texts = "Todos";
            view.SelectedBillingType.Texts = "Todos";
            view.EndDateCalendar.MaxDate = DateTime.Now.Date;
            view.EndDateCalendar.Value = DateTime.Now.Date;

            view.StartDateCalendar.MaxDate = DateTime.Now.Date;
            view.StartDateCalendar.Value = DateTime.Now.Date;

            view.EndDateCalendar.Visible = false;
            orders = ordersBackup;
            view.OrdersList = orders;
            view.LoadOrders();
        }

        private async void ShowOrderDetailsEvent(object sender, DataGridViewCellEventArgs e)
        {
            int linkColumnIndex = 7;
            if (e.ColumnIndex == linkColumnIndex)
            {
                int id = Convert.ToInt32(view.OrdersList!.ElementAt(e.RowIndex).Id);
                Order Order = await billingRepository.GetBillingById(id);

                PrintedBillingForm printedBillingForm = new();
                printedBillingForm.SetDataToPrintedBillingForm(Order);

                homePresenter.SetPrintedBilling(printedBillingForm);
                homePresenter.ShowPrintedBilling();
            }
        }

        private void SearchEvent(object sender, EventArgs e)
        {
            SearchTimer.Stop();

            if (view.Search != previousSearchText)
            {
                previousSearchText = view.Search!;
                SearchTimer.Start();
            }
        }

        private void FilterEvent(object sender, EventArgs e)
        {
            IEnumerable<Order>? OrdersToFilter = ordersBackup;
            view.Search = string.Empty;
            if (view.StartDateCalendar.Value != DateTime.Now.Date)
            {
                view.EndDateCalendar.Visible = true;
                view.EndDateCalendar.MinDate = view.StartDateCalendar.Value;
                view.StartDateCalendar.MaxDate = view.EndDateCalendar.Value.AddDays(-1);
                view.EndDateCalendar.MinDate = view.StartDateCalendar.Value.AddDays(1);

                OrdersToFilter = OrdersToFilter?.Where(o => o.CreatedAt >= view.StartDateCalendar.Value);
            }

            if (view.EndDateCalendar.Value != DateTime.Now.Date)
            {
                view.StartDateCalendar.MaxDate = view.EndDateCalendar.Value;
                view.StartDateCalendar.MaxDate = view.EndDateCalendar.Value.AddDays(-1);
                view.EndDateCalendar.MinDate = view.StartDateCalendar.Value.AddDays(1);


                OrdersToFilter = OrdersToFilter?.Where(o => o.CreatedAt <= view.EndDateCalendar.Value);
            }

            if (view.SelectedPaymentMethod.Texts != "Todos")
            {
                OrdersToFilter = OrdersToFilter?.Where(o => o.PaymentMethod.Description == view.SelectedPaymentMethod.Texts);
            }

            if (view.SelectedBillingType.Texts != "Todos")
            {
                OrdersToFilter = OrdersToFilter?.Where(o => o.BillingType.Description == view.SelectedBillingType.Texts);
            }

            view.OrdersList = OrdersToFilter;
            orders = OrdersToFilter;
            view.LoadOrders();
        }

        private void EditEvent(object sender, EventArgs e)
        {
            Order Order = (Order)sender;
            this.view.Close();
            this.homePresenter.ShowOrderView(Order, e);
        }
    }
}
