using System;
using System.Collections.Generic;

namespace CorazonDeCafeStockManager.App.Models;

public partial class Order
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public string? CustomerCuil { get; set; }

    public int Status { get; set; }

    public double TotalPrice { get; set; }

    public int PaymentMethodId { get; set; }

    public int BillingTypeId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual BillingType BillingType { get; set; } = null!;

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    public virtual PaymentMethod PaymentMethod { get; set; } = null!;
}
