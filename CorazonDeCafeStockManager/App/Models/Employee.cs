﻿using System;
using System.Collections.Generic;

namespace CorazonDeCafeStockManager.App.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public int UserId { get; set; }

    public int RoleId { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Product> ProductCreatedBies { get; set; } = new List<Product>();

    public virtual ICollection<Product> ProductUpdatedBies { get; set; } = new List<Product>();

    public virtual Role Role { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
