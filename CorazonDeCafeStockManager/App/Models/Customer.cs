﻿using System;
using System.Collections.Generic;

namespace CorazonDeCafeStockManager.App.Models;

public partial class Customer
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual User User { get; set; } = null!;
}
