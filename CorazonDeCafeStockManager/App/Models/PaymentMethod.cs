using System;
using System.Collections.Generic;

namespace CorazonDeCafeStockManager.App.Models;

public partial class PaymentMethod
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
