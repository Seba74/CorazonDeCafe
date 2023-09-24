using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Repositories._Repository;
using CorazonDeCafeStockManager.App.Views.CustomersForm;
using CorazonDeCafeStockManager.App.Views.EmployeeForm;
using CorazonDeCafeStockManager.App.Views.EmployeesForm;
using CorazonDeCafeStockManager.App.Views.HomeForm;
using CorazonDeCafeStockManager.App.Views.ProductForm;
using CorazonDeCafeStockManager.App.Views.ProductsForm;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class HomePresenter
    {
        private readonly CorazonDeCafeContext dbContext;
        private readonly IHomeView view;
        private IProductsView? productsView;
        private ICustomersView? customersView;
        private IEmployeesView? employeesView;
        private IProductView? productView;
        private IEmployeeView? employeeView;

        private ProductsPresenter? productsPresenter { get; set; }
        private ProductPresenter? productPresenter { get; set; }
        private CustomersPresenter? customersPresenter { get; set; }
        private EmployeesPresenter? employeesPresenter { get; set; }
        private EmployeePresenter? employeePresenter { get; set; }
        public HomePresenter(IHomeView view, CorazonDeCafeContext dbContext)
        {
            this.view = view;
            this.dbContext = dbContext;
            this.view.ShowProductsView += ShowProductsView;
            this.view.ShowCustomersView += ShowCustomersView;
            this.view.ShowEmployeesView += ShowEmployeesView;
            this.view.CloseView += CloseView;
        }

        public void ShowHomeView()
        {
            ShowProductsView(this, EventArgs.Empty);
            view.Show();
        }

        public void ShowProductsView(object? sender, EventArgs e)
        {
            this.CloseView(sender, e);
            view.RemoveBackgroundBtns();
            view.ProductButton.BackColor = Color.FromArgb(255, 219, 197);

            view.IconHeader.BackgroundImage = Properties.Resources.coffee1;
            view.TitleHeader.Text = "PRODUCTOS";

            IProductRepository productRepository = new ProductRepository(dbContext);
            productsView = ProductsForm.GetInstance(view.ControlPanel);
            productsPresenter = new(productsView, productRepository, this);
        }

        public void ShowProductView(object? sender, EventArgs e)
        {
            this.CloseView(sender, e);
            Product? product = null;
            if(sender != null)
            {
                product = (Product)sender;
            }

            IProductRepository productRepository = new ProductRepository(dbContext);
            productView = ProductForm.GetInstance(view.ControlPanel);
      
            productPresenter = new(productView, productRepository, product!, this);
        }
        public void ShowCustomersView(object? sender, EventArgs e)
        {
            this.CloseView(sender, e);
            view.RemoveBackgroundBtns();
            view.CustomerButton.BackColor = Color.FromArgb(255, 219, 197);

            view.IconHeader.BackgroundImage = Properties.Resources.users;
            view.TitleHeader.Text = "CLIENTES";

            ICustomerRepository customerRepository = new CustomerRepository(dbContext);
            customersView = CustomersForm.GetInstance(view.ControlPanel);
            customersPresenter = new(customersView, customerRepository, this);
        }
        public void ShowEmployeesView(object? sender, EventArgs e)
        {
            this.CloseView(sender, e);
            view.RemoveBackgroundBtns();
            view.EmployeeButton.BackColor = Color.FromArgb(255, 219, 197);

            view.IconHeader.BackgroundImage = Properties.Resources.employees;
            view.TitleHeader.Text = "EMPLEADOS";

            IEmployeeRepository employeeRepository = new EmployeeRepository(dbContext);
            employeesView = EmployeesForm.GetInstance(view.ControlPanel);
            employeesPresenter = new(employeesView, employeeRepository, this);
        }

        public void ShowEmployeeView(object? sender, EventArgs e)
        {
            this.CloseView(sender, e);
            Employee? Employee = null;
            if(sender != null)
            {
                Employee = (Employee)sender;
            }

            IEmployeeRepository EmployeeRepository = new EmployeeRepository(dbContext);
            employeeView = EmployeeForm.GetInstance(view.ControlPanel);
      
            employeePresenter = new(employeeView, EmployeeRepository, Employee!, this);
        }

        private void CloseView(object? sender, EventArgs e)
        {
            productPresenter?.CloseView();
            productsPresenter?.CloseView();
            customersPresenter?.CloseView();
            employeesPresenter?.CloseView();
        }
    }
}
