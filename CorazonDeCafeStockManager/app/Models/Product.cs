using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorazonDeCafeStockManager
{
    internal class Product
    {
        public int Id { get; set; }
        public int? Categoria_Id { get; set; }
        public int? Tipo_Id { get; set; }
        public required string? Nombre { get; set; }
        public required string? Estado { get; set; }
        public string? Imagen { get; set; }
        public float? Precio { get; set; }
        public int? Stock { get; set; }
    }
}
