using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CorazonDeCafeStockManager
{
    internal class Tipo
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string? Nombre { get; set; }

        [DisplayName("Description")]
        [Required(ErrorMessage = "La descripcion es requerida")]
        public string? Descripcion { get; set; }

        [DisplayName("Active")]
        [Required(ErrorMessage = "El estado es requerido")]
        public string? Activo { get; set; }
    }
}
