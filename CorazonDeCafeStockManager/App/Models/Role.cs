using System;
using System.Collections.Generic;

namespace CorazonDeCafeStockManager.App.Models;

public partial class Role
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Status { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
