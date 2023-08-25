using System;
using System.Collections.Generic;

namespace CorazonDeCafeStockManager.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public float Precio { get; set; }

    public string Imagen { get; set; } = null!;

    public int CategoriaId { get; set; }

    public int TipoId { get; set; }

    public string Estado { get; set; } = null!;

    public int? Stock { get; set; }

    public virtual ICollection<CartProducto> CartProductos { get; set; } = new List<CartProducto>();

    public virtual Categoria Categoria { get; set; } = null!;

    public virtual Tipo Tipo { get; set; } = null!;
}
