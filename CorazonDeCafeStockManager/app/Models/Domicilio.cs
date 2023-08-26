using System;
using System.Collections.Generic;

namespace CorazonDeCafeStockManager.App.Models;

public partial class Domicilio
{
    public int Id { get; set; }

    public string Calle { get; set; } = null!;

    public int Numero { get; set; }

    public int CodigoPostal { get; set; }

    public string Ciudad { get; set; } = null!;

    public string Pais { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
