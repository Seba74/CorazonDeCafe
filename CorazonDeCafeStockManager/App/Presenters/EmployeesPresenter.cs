﻿using CorazonDeCafeStockManager.App.Models;
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
            employees = await employeeRepository.GetAllEmployees();
            employeesBackUp = employees;
            view.EmployeesList = employees;
            view.LoadEmployees();
        }

        public void ShowView()
        {
            view!.Show();
        }

        public void CloseView()
        {
            view!.Close();
        }

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

            view.endDateCalendar.MaxDate = DateTime.Now.Date;
            view.endDateCalendar.Value = DateTime.Now.Date;

            view.startDateCalendar.MaxDate = DateTime.Now.Date;
            view.startDateCalendar.Value = DateTime.Now.Date;

            view.endDateCalendar.Visible = false;
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
            if (view.startDateCalendar.Value != DateTime.Now.Date)
            {
                view.endDateCalendar.Visible = true;
                view.endDateCalendar.MinDate = view.startDateCalendar.Value;
                view.startDateCalendar.MaxDate = view.endDateCalendar.Value.AddDays(-1);
                view.endDateCalendar.MinDate = view.startDateCalendar.Value.AddDays(1);

                EmployeesToFilter = EmployeesToFilter?.Where(p => p.User.CreatedAt >= view.startDateCalendar.Value);
            }

            if (view.endDateCalendar.Value != DateTime.Now.Date)
            {
                view.startDateCalendar.MaxDate = view.endDateCalendar.Value;
                view.startDateCalendar.MaxDate = view.endDateCalendar.Value.AddDays(-1);
                view.endDateCalendar.MinDate = view.startDateCalendar.Value.AddDays(1);


                EmployeesToFilter = EmployeesToFilter?.Where(p => p.User.CreatedAt <= view.endDateCalendar.Value);
            }

            view.EmployeesList = EmployeesToFilter;
            employees = EmployeesToFilter;
            view.LoadEmployees();
        }

        private void AddEvent(object sender, EventArgs e)
        {
            // this.view.Close();
            // this.homePresenter.ShowEmployeeView(null, e);
        }

        private void EditEvent(object sender, EventArgs e)
        {
            // Client Employee = (Client)sender;
            // this.view.Close();
            // this.homePresenter.ShowEmployeeView(Employee, e);
        }
    }
}