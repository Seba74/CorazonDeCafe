﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Views.EmployeesForm
{
    public partial class EmployeesForm : Form, IEmployeesView
    {
        private readonly LoadFonts loadFonts;
        public string? Search
        {
            get { return ipSearch.Texts; }
            set { ipSearch.Texts = value!; }
        }

        public CalendarCustom startDateCalendar {
            get { return startDate; }
            set { startDate = value!; }
        }
        public CalendarCustom endDateCalendar {
            get { return endDate; }
            set { endDate = value!; }
        }
        
        public IEnumerable<Employee>? EmployeesList { get; set; }

        public EmployeesForm()
        {
            InitializeComponent();
            InitializeEvents();

            loadFonts = new LoadFonts();
            ChangeDataGridViewFont(employeesDataGrid);

            ipSearch.Font = loadFonts.poppinsFont;
            startDate.Font = new Font(loadFonts.poppinsFont!.FontFamily, 9);
            endDate.Font = new Font(loadFonts.poppinsFont!.FontFamily, 9);

            startDateCalendar.Value = DateTime.Now.Date;
            endDateCalendar.Value = DateTime.Now.Date;
            startDateCalendar.MaxDate = DateTime.Now.Date;
            endDateCalendar.MaxDate = DateTime.Now.Date;
        }
        private void InitializeEvents()
        {
            ipSearch._TextChanged += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            startDate.ValueChanged += delegate { FilterEvent?.Invoke(this, EventArgs.Empty); };
            endDate.ValueChanged += delegate { FilterEvent?.Invoke(this, EventArgs.Empty); };
            reload.Click += delegate { ResetEmployeesEvent?.Invoke(this, EventArgs.Empty); };
            btnAdd.Click += delegate { AddEvent?.Invoke(this, EventArgs.Empty); };
            btnEdit.Click += delegate
            {
                if (employeesDataGrid.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(employeesDataGrid.SelectedRows[0].Cells[0].Value);
                    Employee Employee = EmployeesList!.Where(p => p.Id == id).FirstOrDefault()!;
                    EditEvent?.Invoke(Employee, EventArgs.Empty);
                }
            };
        }

        public event EventHandler? SearchEvent;
        public event EventHandler? FilterEvent;
        public event EventHandler? ResetEmployeesEvent;
        public event EventHandler? AddEvent;
        public event EventHandler? EditEvent;

        public void LoadEmployees()
        {
            if (employeesDataGrid.InvokeRequired)
            {
                employeesDataGrid.Invoke(new MethodInvoker(delegate
                {
                    employeesDataGrid.Rows.Clear();
                    employeesDataGrid.Refresh();

                    foreach (Employee employee in EmployeesList!)
                    {
                        string active = employee.User.Status == 1 ? "Activo" : "Inactivo";
                        string fullName = employee.User.Name + " " + employee.User.Surname;

                        employeesDataGrid.Rows.Add(employee.Id, fullName, employee.User.Email, employee.User.Dni, employee.User.Phone, employee.Role.Name, active);
                    }
                }));
            }
            else
            {
                employeesDataGrid.Rows.Clear();
                employeesDataGrid.Refresh();

                foreach (Employee employee in EmployeesList!)
                {
                    string active = employee.User.Status == 1 ? "Activo" : "Inactivo";
                    string fullName = employee.User.Name + " " + employee.User.Surname;

                    employeesDataGrid.Rows.Add(employee.Id, fullName, employee.User.Email, employee.User.Dni, employee.User.Phone, employee.Role.Name, active);
                }
            }
        }


        public void ChangeDataGridViewFont(DataGridView dataGridView)
        {
            Color colorFondoEncabezado = Color.FromArgb(146, 90, 57);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = colorFondoEncabezado;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.DefaultCellStyle.Font = loadFonts.poppinsFont;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = loadFonts.poppinsFont;
        }
        public void ShowError(string message)
        {
            throw new NotImplementedException();
        }

        private static EmployeesForm? instance;
        public static EmployeesForm GetInstance(Control controlParent)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new EmployeesForm
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                };
                controlParent.Controls.Clear();
                controlParent.Controls.Add(instance);
                instance.Show();
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}
