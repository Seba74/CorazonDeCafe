using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Views.EmployeesForm
{
    public interface IEmployeesView
    {

        // Properties 
        string? Search { get; set; }
        Size Size { get; set; }
        IEnumerable<Employee>? EmployeesList { get; set; }
        CalendarCustom StartDateCalendar { get; set; }
        CalendarCustom EndDateCalendar { get; set; }
        ComboBoxCustom SelectedRole { get; set; }
        // Events
        event EventHandler? SearchEvent;
        event EventHandler? FilterEvent;
        event EventHandler? ResetEmployeesEvent;
        event EventHandler? AddEvent;
        event EventHandler? EditEvent;

        // Methods
        void ShowError(string message);
        void LoadEmployees();
        void Show();
        void Hide();
        void Close();
    }
}
