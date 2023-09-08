﻿using System;
using System.Collections.Generic;

namespace CorazonDeCafeStockManager.App.Models;

public partial class Order
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public DateTime? CreateAt { get; set; }

    public int Status { get; set; }

    public double TotalPrice { get; set; }

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    public virtual User? User { get; set; }
}