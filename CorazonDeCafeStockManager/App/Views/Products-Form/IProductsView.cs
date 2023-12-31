﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Views.ProductsForm
{
    public interface IProductsView
    {

        // Properties 
        string? Search { get; set; }
        string? SelectCategory { get; set; }
        string? SelectType { get; set; }

        Size Size { get; set; }
        IEnumerable<Product>? ProductsList { get; set; }
        DataGridView ProductsGrid { get; set; }
        // Events
        event EventHandler? SearchEvent;
        event EventHandler? FilterEvent;
        event EventHandler? ResetProductsEvent;
        event EventHandler? AddEvent;
        event EventHandler AddProductToCartEvent;
        event EventHandler? EditEvent;

        // Methods
        void ShowError(string message);
        void LoadProducts();
        void Show();

        void Hide();
        void Close();
    }
}
