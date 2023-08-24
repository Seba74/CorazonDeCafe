using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CorazonDeCafeStockManager
{
    internal class Product
    {
        public int Id { get; set; }
        [DisplayName("Category Id")]
        [Required(ErrorMessage = "La categoria es requerida")]
        public int Categoria_Id { get; set; }

        [DisplayName("Type Id")]
        [Required(ErrorMessage = "El tipo es requerido")]
        public int? Tipo_Id { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public required string? Nombre { get; set; }

        [DisplayName("Estado")]
        [Required(ErrorMessage = "El Estado es requerido")]
        public required string? Estado { get; set; }

        [DisplayName("Imagen")]
        [Required(ErrorMessage = "La imagen es requerida")]
        public string? Imagen { get; set; }

        [DisplayName("Precio")]
        [Required(ErrorMessage = "El precio es requerido")]
        public float? Precio { get; set; }

        [DisplayName("Stock")]
        [Required(ErrorMessage = "El stock es requerido")]
        public int? Stock { get; set; }
    }
}
