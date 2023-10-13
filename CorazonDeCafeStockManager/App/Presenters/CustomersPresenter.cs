using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Views.CustomersForm;
using Timer = System.Timers.Timer;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class CustomersPresenter
    {
        private readonly Timer SearchTimer = new(1200);
        private readonly ICustomersView view;
        private readonly HomePresenter homePresenter;
        private readonly ICustomerRepository customerRepository;
        private IEnumerable<Customer>? customers;
        private IEnumerable<Customer>? customersBackUp;
        private string previousSearchText = string.Empty;
        public CustomersPresenter(ICustomersView view, ICustomerRepository customerRepository, HomePresenter homePresenter)
        {
            this.view = view;
            this.homePresenter = homePresenter;
            this.customerRepository = customerRepository;
            this.view.SearchEvent += SearchEvent!;
            this.view.FilterEvent += FilterEvent!;
            this.view.ResetCustomersEvent += ResetCustomersEvent!;
            this.view.AddEvent += AddEvent!;
            this.view.EditEvent += EditEvent!;
            this.view.SelectCustomerEvent += SelectCustomerEvent!;

            SearchTimer.Elapsed += SearchCustomers!;


            _ = LoadAllCustomers();
            this.view.Show();
        }
        public async Task LoadAllCustomers()
        {
            try
            {
                customers = await customerRepository.GetAllCustomers();
                customersBackUp = customers;
                view.CustomersList = customers;
                view.LoadCustomers();
            }
            catch
            {
                view.ShowError("Error al cargar los clientes");
            }
        }

        public void ShowView() => view!.Show();
        public void CloseView() => view!.Close();

        private void SearchCustomers(object sender, EventArgs e)
        {
            SearchTimer.Stop();
            if (!string.IsNullOrEmpty(view.Search))
            {
                if (int.TryParse(view.Search, out int dni))
                {
                    view.CustomersList = customers?.Where(p => p.User.Dni.Equals(dni));
                }
                else
                {
                    view.CustomersList = customers?.Where(p => (p.User.Name + " " + p.User.Surname).ToLowerInvariant().Contains(view.Search!.ToLowerInvariant()));
                }
            }
            else
            {
                view.CustomersList = customers;
            }
            view.LoadCustomers();
        }

        private void ResetCustomersEvent(object sender, EventArgs e)
        {
            view.Search = string.Empty;

            view.endDateCalendar.MaxDate = DateTime.Now.Date;
            view.endDateCalendar.Value = DateTime.Now.Date;

            view.startDateCalendar.MaxDate = DateTime.Now.Date;
            view.startDateCalendar.Value = DateTime.Now.Date;

            view.endDateCalendar.Visible = false;
            customers = customersBackUp;
            view.CustomersList = customers;
            view.LoadCustomers();
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
            IEnumerable<Customer>? CustomersToFilter = customersBackUp;
            view.Search = string.Empty;
            if (view.startDateCalendar.Value != DateTime.Now.Date)
            {
                view.endDateCalendar.Visible = true;
                view.endDateCalendar.MinDate = view.startDateCalendar.Value;
                view.startDateCalendar.MaxDate = view.endDateCalendar.Value.AddDays(-1);
                view.endDateCalendar.MinDate = view.startDateCalendar.Value.AddDays(1);

                CustomersToFilter = CustomersToFilter?.Where(p => p.User.CreatedAt >= view.startDateCalendar.Value);
            }

            if (view.endDateCalendar.Value != DateTime.Now.Date)
            {
                view.startDateCalendar.MaxDate = view.endDateCalendar.Value;
                view.startDateCalendar.MaxDate = view.endDateCalendar.Value.AddDays(-1);
                view.endDateCalendar.MinDate = view.startDateCalendar.Value.AddDays(1);


                CustomersToFilter = CustomersToFilter?.Where(p => p.User.CreatedAt <= view.endDateCalendar.Value);
            }

            view.CustomersList = CustomersToFilter;
            customers = CustomersToFilter;
            view.LoadCustomers();
        }

        private void AddEvent(object sender, EventArgs e)
        {
            this.view.Close();
            this.homePresenter.ShowCustomerView(null, e);
        }

        private void EditEvent(object sender, EventArgs e)
        {
            Customer Customer = (Customer)sender;
            this.view.Close();
            this.homePresenter.ShowCustomerView(Customer, e);
        }

        private void SelectCustomerEvent(object sender, EventArgs e)
        {
            Customer Customer = (Customer)sender;
            this.view.Close();
            this.homePresenter.ShowBillingView(Customer, e);
        }
    }
}
