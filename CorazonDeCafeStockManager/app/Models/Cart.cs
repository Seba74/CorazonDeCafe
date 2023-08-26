using System;
using System.Collections.Generic;

namespace CorazonDeCafeStockManager.App.Models;

public partial class Cart
{
    public int Id { get; set; }

    public int? UsuarioId { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? Estado { get; set; }

    public decimal? Total { get; set; }

    public virtual ICollection<CartProducto> CartProductos { get; set; } = new List<CartProducto>();

    public virtual Usuario? Usuario { get; set; }
}
