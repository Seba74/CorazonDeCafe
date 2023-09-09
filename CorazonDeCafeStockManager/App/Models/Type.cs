using System;
using System.Collections.Generic;

namespace CorazonDeCafeStockManager.App.Models;

public partial class Type
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Status { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
