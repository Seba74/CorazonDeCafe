using System;
using System.Collections.Generic;

namespace CorazonDeCafeStockManager.App.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double Price { get; set; }

    public string Imagen { get; set; } = null!;

    public int Stock { get; set; }

    public int CategoryId { get; set; }

    public int TypeId { get; set; }

    public int Status { get; set; }

    public int Active { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    public virtual Type Type { get; set; } = null!;
}
