using System;
using System.Collections.Generic;

namespace CorazonDeCafeStockManager.App.Models;

public partial class Tipo
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Activo { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
