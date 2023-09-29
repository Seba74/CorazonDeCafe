using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Views.EmployeesForm;
using Timer = System.Timers.Timer;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class EmployeesPresenter
    {
        private readonly Timer SearchTimer = new(1200);
        private readonly IEmployeesView view;
        private readonly HomePresenter homePresenter;
        private readonly IEmployeeRepository employeeRepository;
        private IEnumerable<Employee>? employees;
        private IEnumerable<Employee>? employeesBackUp;
        private string previousSearchText = string.Empty;
        public EmployeesPresenter(IEmployeesView view, IEmployeeRepository employeeRepository, HomePresenter homePresenter)
        {
            this.view = view;
            this.homePresenter = homePresenter;
            this.employeeRepository = employeeRepository;
            this.view.SearchEvent += SearchEvent!;
            this.view.FilterEvent += FilterEvent!;
            this.view.ResetEmployeesEvent += ResetEmployeesEvent!;
            this.view.AddEvent += AddEvent!;
            this.view.EditEvent += EditEvent!;

            SearchTimer.Elapsed += SearchEmployees!;


            _ = LoadAllEmployees();
            this.view.Show();
        }
        public async Task LoadAllEmployees()
        {
            try
            {
                employees = await employeeRepository.GetAllEmployees();
                employeesBackUp = employees;
                view.EmployeesList = employees;
                view.LoadEmployees();
            }
            catch (Exception e)
            {
                view.ShowError(e.Message);
            }
        }

        public void ShowView() => view.Show();
        public void CloseView() => view.Close();

        private void SearchEmployees(object sender, EventArgs e)
        {
            SearchTimer.Stop();
            if (!string.IsNullOrEmpty(view.Search))
            {
                if (int.TryParse(view.Search, out int id))
                {
                    view.EmployeesList = employees?.Where(p => p.Id == id);
                }
                else
                {
                    view.EmployeesList = employees?.Where(p => (p.User.Name + " " + p.User.Surname).ToLowerInvariant().Contains(view.Search!.ToLowerInvariant()));
                }
            }
            else
            {
                view.EmployeesList = employees;
            }
            view.LoadEmployees();
        }


        private void ResetEmployeesEvent(object sender, EventArgs e)
        {
            view.Search = string.Empty;

            view.SelectedRole.Texts = "Todos";
            view.EndDateCalendar.MaxDate = DateTime.Now.Date;
            view.EndDateCalendar.Value = DateTime.Now.Date;

            view.StartDateCalendar.MaxDate = DateTime.Now.Date;
            view.StartDateCalendar.Value = DateTime.Now.Date;

            view.EndDateCalendar.Visible = false;
            employees = employeesBackUp;
            view.EmployeesList = employees;
            view.LoadEmployees();
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
            IEnumerable<Employee>? EmployeesToFilter = employeesBackUp;
            view.Search = string.Empty;
            if (view.StartDateCalendar.Value != DateTime.Now.Date)
            {
                view.EndDateCalendar.Visible = true;
                view.EndDateCalendar.MinDate = view.StartDateCalendar.Value;
                view.StartDateCalendar.MaxDate = view.EndDateCalendar.Value.AddDays(-1);
                view.EndDateCalendar.MinDate = view.StartDateCalendar.Value.AddDays(1);

                EmployeesToFilter = EmployeesToFilter?.Where(p => p.User.CreatedAt >= view.StartDateCalendar.Value);
            }

            if (view.EndDateCalendar.Value != DateTime.Now.Date)
            {
                view.StartDateCalendar.MaxDate = view.EndDateCalendar.Value;
                view.StartDateCalendar.MaxDate = view.EndDateCalendar.Value.AddDays(-1);
                view.EndDateCalendar.MinDate = view.StartDateCalendar.Value.AddDays(1);


                EmployeesToFilter = EmployeesToFilter?.Where(p => p.User.CreatedAt <= view.EndDateCalendar.Value);
            }

            if (view.SelectedRole.Texts != "Todos")
            {
                EmployeesToFilter = EmployeesToFilter?.Where(p => p.Role.Name == view.SelectedRole.Texts);
            }

            view.EmployeesList = EmployeesToFilter;
            employees = EmployeesToFilter;
            view.LoadEmployees();
        }

        private void AddEvent(object sender, EventArgs e)
        {
            this.view.Close();
            this.homePresenter.ShowEmployeeView(null, e);
        }

        private void EditEvent(object sender, EventArgs e)
        {
            Employee Employee = (Employee)sender;
            this.view.Close();
            this.homePresenter.ShowEmployeeView(Employee, e);
        }
    }
}
