using System;
using System.Collections.Generic;

namespace CorazonDeCafeStockManager.App.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Dni { get; set; }

    public int? AddressId { get; set; }

    public int Status { get; set; }

    public string? Phone { get; set; }

    public virtual Address? Address { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
