using System;
using System.Collections.Generic;

namespace CorazonDeCafeStockManager.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Usuario1 { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public int? DomicilioId { get; set; }

    public int? RoleId { get; set; }

    public string Baja { get; set; } = null!;

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual Domicilio? Domicilio { get; set; }

    public virtual Role? Role { get; set; }
}
