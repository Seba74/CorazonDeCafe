using System;
using System.Collections.Generic;

namespace CorazonDeCafeStockManager.Models;

public partial class Role
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Activo { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
