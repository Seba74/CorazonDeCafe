using System;
using System.Collections.Generic;

namespace CorazonDeCafeStockManager.App.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Username { get; set; } = null!;

    public int Dni { get; set; }

    public string Pass { get; set; } = null!;

    public int RoleId { get; set; }

    public int? AddressId { get; set; }

    public int Status { get; set; }

    public string? Phone { get; set; }

    public virtual Address? Address { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Role Role { get; set; } = null!;
}
