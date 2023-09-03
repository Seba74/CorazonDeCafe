﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Views.Login_Form
{
    public interface IProductsView
    {

        // Properties 
        string? Search { get; set; }
        IEnumerable<Product>? ProductsList { get; set; }
        // Events
        event EventHandler? SearchEvent;
        event EventHandler? AddEvent;
        event EventHandler? EditEvent;
        event EventHandler? DeleteEvent;

        // Methods
        void ShowError(string message);
        void LoadProducts();
        void Show();
        void Close();
    }
}