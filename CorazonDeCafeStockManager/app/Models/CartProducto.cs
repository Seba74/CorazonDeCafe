using System;
using System.Collections.Generic;

namespace CorazonDeCafeStockManager.App.Models;

public partial class CartProducto
{
    public int Id { get; set; }

    public int? CartId { get; set; }

    public int? ProductId { get; set; }

    public decimal? Precio { get; set; }

    public int? Cantidad { get; set; }

    public virtual Cart? Cart { get; set; }

    public virtual Product? Product { get; set; }
}
