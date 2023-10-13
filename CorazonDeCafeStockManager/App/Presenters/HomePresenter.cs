﻿using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Repositories._Repository;
using CorazonDeCafeStockManager.App.Views.BackupForm;
using CorazonDeCafeStockManager.App.Views.BillingForm;
using CorazonDeCafeStockManager.App.Views.CustomerForm;
using CorazonDeCafeStockManager.App.Views.CustomersForm;
using CorazonDeCafeStockManager.App.Views.EmployeeForm;
using CorazonDeCafeStockManager.App.Views.EmployeesForm;
using CorazonDeCafeStockManager.App.Views.HomeForm;
using CorazonDeCafeStockManager.App.Views.LoginForm;
using CorazonDeCafeStockManager.App.Views.ProductForm;
using CorazonDeCafeStockManager.App.Views.ProductsForm;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class HomePresenter
    {
        private readonly CorazonDeCafeContext dbContext;
        private IHomeView view;
        private IProductsView? productsView;
        private ICustomersView? customersView;
        private IEmployeesView? employeesView;
        private IBackupView? backupView;
        private IProductView? productView;
        private IEmployeeView? employeeView;
        private IBillingView? billingView;
        private ICustomerView? customerView;

        // Presenter
        private BillingPresenter? billingPresenter;
        public HomePresenter(IHomeView view, CorazonDeCafeContext dbContext)
        {
            this.view = view;
            this.dbContext = dbContext;

            this.view.LogoutEvent += LogoutEvent;
            this.view.ShowProductsView += ShowProductsView;
            this.view.ShowCustomersView += ShowCustomersView;
            this.view.ShowEmployeesView += ShowEmployeesView;
            this.view.ShowBackupView += ShowBackupView;
            this.view.ShowBillingView += ShowBillingView;
            this.view.CloseView += CloseView;
        }

        public void ShowHomeView()
        {
            ShowCustomersView(this, EventArgs.Empty);
            VerifyRole();
            view.Show();
        }

        private void VerifyRole()
        {

            if (SessionManager.RoleId != 1)
            {
                view.BackupButton.Visible = false;
            }

            if (SessionManager.RoleId != 1 && SessionManager.RoleId != 2)
            {
                view.EmployeeButton.Visible = false;
                view.ReportButton.Visible = false;
            }

            if (SessionManager.RoleId == 3 || SessionManager.RoleId == 4)
            {
                view.BillingButton.Visible = true;
            }

            if (SessionManager.RoleId == 4)
            {
                view.SaleButton.Visible = false;
            }
        }

        public void ShowProductsView(object? sender, EventArgs e)
        {
            if (productsView != null)
            {
                return;
            }

            this.CloseView(sender, e);
            view.RemoveBackgroundBtns();
            view.ProductButton.BackColor = Color.FromArgb(255, 219, 197);

            view.IconHeader.BackgroundImage = Properties.Resources.coffee1;
            view.TitleHeader.Text = "PRODUCTOS";

            IProductRepository productRepository = new ProductRepository(dbContext);
            productsView = ProductsForm.GetInstance(view.ControlPanel);
            ProductsPresenter ProductsPresenter = new(productsView, productRepository, this);
        }

        public void ShowProductView(object? sender, EventArgs e)
        {
            if (productView != null)
            {
                return;
            }

            this.CloseView(sender, e);
            Product? product = null;
            if (sender != null)
            {
                product = (Product)sender;
            }

            IProductRepository productRepository = new ProductRepository(dbContext);
            productView = ProductForm.GetInstance(view.ControlPanel);

            ProductPresenter ProductPresenter = new(productView, productRepository, product!, this);
        }
        public void ShowCustomersView(object? sender, EventArgs e)
        {
            if (customersView != null)
            {
                return;
            }

            this.CloseView(sender, e);
            view.RemoveBackgroundBtns();
            view.CustomerButton.BackColor = Color.FromArgb(255, 219, 197);

            view.IconHeader.BackgroundImage = Properties.Resources.users;
            view.TitleHeader.Text = "CLIENTES";

            ICustomerRepository customerRepository = new CustomerRepository(dbContext);
            customersView = CustomersForm.GetInstance(view.ControlPanel);
            CustomersPresenter CustomersPresenter = new(customersView, customerRepository, this);
        }

        public void ShowCustomerView(object? sender, EventArgs e)
        {
            if (customerView != null)
            {
                return;
            }

            this.CloseView(sender, e);
            Customer? Customer = null;
            if (sender != null)
            {
                Customer = (Customer)sender;
            }

            ICustomerRepository CustomerRepository = new CustomerRepository(dbContext);
            customerView = CustomerForm.GetInstance(view.ControlPanel);

            CustomerPresenter CustomerPresenter = new(customerView, CustomerRepository, Customer!, this);
        }
        public void ShowEmployeesView(object? sender, EventArgs e)
        {
            if (employeesView != null)
            {
                return;
            }

            this.CloseView(sender, e);
            view.RemoveBackgroundBtns();
            view.EmployeeButton.BackColor = Color.FromArgb(255, 219, 197);

            view.IconHeader.BackgroundImage = Properties.Resources.employees;
            view.TitleHeader.Text = "EMPLEADOS";

            IEmployeeRepository employeeRepository = new EmployeeRepository(dbContext);
            employeesView = EmployeesForm.GetInstance(view.ControlPanel);
            EmployeesPresenter EmployeesPresenter = new(employeesView, employeeRepository, this);
        }

        public void ShowEmployeeView(object? sender, EventArgs e)
        {
            if (employeeView != null)
            {
                return;
            }

            this.CloseView(sender, e);
            Employee? Employee = null;
            if (sender != null)
            {
                Employee = (Employee)sender;
            }

            IEmployeeRepository EmployeeRepository = new EmployeeRepository(dbContext);
            employeeView = EmployeeForm.GetInstance(view.ControlPanel);

            EmployeePresenter EmployeePresenter = new(employeeView, EmployeeRepository, Employee!, this);
        }
        public void ShowBillingView(object? sender, EventArgs e)
        {

            Customer? customer = null;
            this.CloseView(sender, e);
            view.RemoveBackgroundBtns();
            view.BillingButton.BackColor = Color.FromArgb(255, 219, 197);

            view.IconHeader.BackgroundImage = Properties.Resources.billing;
            view.TitleHeader.Text = "FACTURACIÓN";

            if (sender != null)
            {
                customer = (Customer)sender;
            }

            IBillingRepository billingRepository = new BillingRepository(dbContext);
            ICustomerRepository customerRepository = new CustomerRepository(dbContext);
            IProductRepository productRepository = new ProductRepository(dbContext);
            billingView = BillingForm.GetInstance(view.ControlPanel);

            productsView = ProductsForm.GetInstance(billingView.PanelProducts);
            ProductsPresenter productsPresenter = new(productsView, productRepository, this);

            billingPresenter = new(billingView, billingRepository, customerRepository, productsPresenter, this, customer!);
        }
        public void ShowBackupView(object? sender, EventArgs e)
        {
            if (backupView != null)
            {
                return;
            }

            this.CloseView(sender, e);
            view.RemoveBackgroundBtns();
            view.BackupButton.BackColor = Color.FromArgb(255, 219, 197);

            view.IconHeader.BackgroundImage = Properties.Resources.backup2;
            view.TitleHeader.Text = "EMPLEADOS";

            IBackupRepository backupRepository = new BackupRepository(dbContext);
            backupView = BackupForm.GetInstance(view.ControlPanel);
            BackupPresenter BackupPresenter = new(backupView, backupRepository, this);
        }

        private void LogoutEvent(object? sender, EventArgs e)
        {
            // are you sure to logout message dialog
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                SessionManager.Logout();
                view.Close();
                _ = new AuthPresenter(dbContext);
            }
        }

        private void CloseView(object? sender, EventArgs e)
        {
            if (productView != null)
            {
                productView.Close();
                productView = null;
            }
            if (productsView != null)
            {
                productsView.Close();
                productsView = null;
            }
            if (customersView != null)
            {
                customersView.Close();
                customersView = null;
            }
            if (customerView != null)
            {
                customerView.Close();
                customerView = null;
            }
            if (backupView != null)
            {
                backupView.Close();
                backupView = null;
            }
            if (employeeView != null)
            {
                employeeView.Close();
                employeeView = null;
            }
            if (employeesView != null)
            {
                employeesView.Close();
                employeesView = null;
            }

            if (billingView != null)
            {
                billingView.Close();
                billingView = null;
            }
        }
    }
}
