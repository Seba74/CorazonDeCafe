using System;
using System.Collections.Generic;

namespace CorazonDeCafeStockManager.App.Models;

public partial class Address
{
    public int Id { get; set; }

    public string Street { get; set; } = null!;

    public int Number { get; set; }

    public string City { get; set; } = null!;

    public string Province { get; set; } = null!;

    public int PostalCode { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
