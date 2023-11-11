using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.EntityData;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Views.ReportsForm;
using Google.Protobuf.WellKnownTypes;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class ReportsPresenter
    {
        private readonly IReportsView view;
        private readonly IBillingRepository billingRepository;
        private readonly OrdersPresenter ordersPresenter;
        private readonly HomePresenter homePresenter;
        public ReportsPresenter(IReportsView view, IBillingRepository billingRepository, OrdersPresenter ordersPresenter, HomePresenter homePresenter)
        {
            this.view = view;
            this.homePresenter = homePresenter;
            this.billingRepository = billingRepository;
            this.ordersPresenter = ordersPresenter;

            this.view.SearchBillingsEvent += SearchBillingsEvent;
            this.view.SearchAmountEvent += SearchAmountEvent;

            LoadBillings();
            _ = LoadData();



            this.view.Show();

        }

        private void LoadCharts()
        {
            SearchBillingsEvent(this, EventArgs.Empty);
            SearchAmountEvent(this, EventArgs.Empty);
        }

        private void LoadBillings()
        {
            IEnumerable<Employee> employees = LocalStorage.Employees!;
            employees = employees.Where(e => e.RoleId == 3 || e.RoleId == 4);

            view.SelectedEmployee.Items.Add("Todos");
            view.SelectedEmployee2.Items.Add("Todos");
            foreach (var employee in employees)
            {
                view.SelectedEmployee.Items.Add(employee.User.Name + " " + employee.User.Surname);
                view.SelectedEmployee2.Items.Add(employee.User.Name + " " + employee.User.Surname);
            }


            view.StartDateBillings.MaxDate = DateTime.Now.Date;
            view.EndDateBillings.MaxDate = DateTime.Now.Date;
            view.StartDateAmount.MaxDate = DateTime.Now.Date;
            view.EndDateAmount.MaxDate = DateTime.Now.Date;

            DateTime startMonth = DateTime.Now;
            startMonth = new DateTime(startMonth.Year, startMonth.Month - 1, 1);

            view.StartDateAmount.Value = startMonth.Date;
            view.StartDateBillings.Value = startMonth.Date;

            view.EndDateBillings.Value = DateTime.Now.Date;
            view.EndDateAmount.Value = DateTime.Now.Date;

        }

        private async Task LoadData()
        {
            Customer customer = await billingRepository.GetCustomerPop();
            PaymentMethod paymentMethod = await billingRepository.GetPaymentMethodPop();
            Product product = await billingRepository.GetProductPop();
            int lastMonthBillings = await billingRepository.GetLastMonthBillings();

            view.ProductPop = product.Name;
            view.CustomerPop = customer.User.Name + " " + customer.User.Surname;
            view.PaymentPop = paymentMethod.Description;
            view.LastOrders = lastMonthBillings.ToString();
        }

        private async void SearchBillingsEvent(object? sender, EventArgs e)
        {
            var startDate = view.StartDateBillings.Value;
            var endDate = view.EndDateBillings.Value;
            var employee = view.SelectedEmployee.SelectedItem ?? "Todos";

            int employeeId = 0;
            if (employee != null && employee.ToString() != "Todos")
            {
                var employeeName = employee.ToString()!.Split(" ");
                var employeeObj = LocalStorage.Employees!.FirstOrDefault(e => e.User.Name == employeeName[0] && e.User.Surname == employeeName[1]);
                employeeId = employeeObj!.Id;
            }

            if (startDate > endDate)
            {
                view.ShowError("La fecha de inicio no puede ser mayor a la fecha final");
                return;
            }

            IEnumerable<OrderStats> orders;
            if (SessionManager.RoleId == 4)
            {
                orders = await billingRepository.GetBillingsByDateAndEmployeeId(startDate, endDate, SessionManager.Id);
            }
            else
            {
                orders = await billingRepository.GetBillingsByDateAndEmployeeId(startDate, endDate, employeeId);
            }

            var chart = view.ChartAmount;

            chart.Series.Clear();
            chart.Series.Add("Total");
            chart.Series["Total"].ChartType = SeriesChartType.SplineArea;

            foreach (var order in orders)
            {
                chart.Series["Total"].Points.AddXY(order.CreatedAt.ToString("dd/MM"), order.Amount);
            }

            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

        }
        private async void SearchAmountEvent(object? sender, EventArgs e)
        {
            var startDate = view.StartDateAmount.Value;
            var endDate = view.EndDateAmount.Value;
            var employee = view.SelectedEmployee2.SelectedItem;

            int employeeId = 0;
            if (employee != null && employee.ToString() != "Todos")
            {
                var employeeName = employee.ToString()!.Split(" ");
                var employeeObj = LocalStorage.Employees!.FirstOrDefault(e => e.User.Name == employeeName[0] && e.User.Surname == employeeName[1]);
                employeeId = employeeObj!.Id;
            }

            if (startDate > endDate)
            {
                view.ShowError("La fecha de inicio no puede ser mayor a la fecha final");
                return;
            }

            IEnumerable<OrderByEmployee> orders = await billingRepository.GetBillingsByEmployee(startDate, endDate, employeeId);
            Chart chart = view.ChartBillings;
            chart.Series.Clear();

            Series series = new()
            {
                ChartType = SeriesChartType.Pie
            };

            foreach (var order in orders)
            {
                var employeeFullName = order.Employee!.User.Name + " " + order.Employee!.User.Surname;
                var totalOrders = order.TotalOrders;
                series.Points.AddXY(employeeFullName, totalOrders);
                series.Points.Last().Label = $"{totalOrders}";
                series.Points.Last().LegendText = employeeFullName;



            }

            chart.Series.Add(series);

            foreach (var point in series.Points)
            {
                point.LabelForeColor = Color.White;
                point.Font = new Font("Arial", 10, FontStyle.Bold);
            }

        }

        public void ShowView() => view!.Show();
        public void CloseView() => view!.Close();

    }
}
