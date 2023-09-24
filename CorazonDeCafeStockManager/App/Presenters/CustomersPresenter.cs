using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Views.CustomersForm;
using CorazonDeCafeStockManager.App.Views.ProductsForm;
using Timer = System.Timers.Timer;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class CustomersPresenter
    {
        private readonly Timer SearchTimer = new(1500);
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

            SearchTimer.Elapsed += SearchCustomers!;

            _ = LoadAllCustomers();
            this.view.Show();
        }
        public async Task LoadAllCustomers()
        {
            customers = await customerRepository.GetAllCustomers();
            customersBackUp = customers;
            view.CustomersList = customers;
            view.LoadCustomers();
        }

        public void ShowView() => view!.Show();
        public void CloseView() => view!.Close();

        private void SearchCustomers(object sender, EventArgs e)
        {
            SearchTimer.Stop();
            if (!string.IsNullOrEmpty(view.Search))
            {
                customers = customers?.Where(p => p.User.Name.ToLowerInvariant().Contains(view.Search!.ToLowerInvariant()));
            }
            else
            {
                customers = view.CustomersList;
            }
            view.CustomersList = customers;
            view.LoadCustomers();
        }


        private void ResetCustomersEvent(object sender, EventArgs e)
        {
            view.Search = string.Empty;
            view.StartDate = DateTime.Now;
            view.EndDate = DateTime.Now;

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
            IEnumerable<Customer>? customersToFilter = customersBackUp;
            view.Search = string.Empty;
            if (view.StartDate != DateTime.Now)
            {
                customersToFilter = customersToFilter?.Where(p => p.User.CreatedAt >= view.StartDate);
            }

            if (view.EndDate != DateTime.Now)
            {
                customersToFilter = customersToFilter?.Where(p => p.User.CreatedAt <= view.EndDate);
            }

            view.CustomersList = customersToFilter;
            customers = customersToFilter;
            view.LoadCustomers();
        }

        private void AddEvent(object sender, EventArgs e)
        {
            // this.view.Close();
            // this.homePresenter.ShowCustomerView(null, e);
        }

        private void EditEvent(object sender, EventArgs e)
        {
            // Client customer = (Client)sender;
            // this.view.Close();
            // this.homePresenter.ShowCustomerView(customer, e);
        }
    }
}
