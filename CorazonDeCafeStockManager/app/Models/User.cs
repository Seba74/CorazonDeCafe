using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CorazonDeCafeStockManager
{
    internal class User
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Address Id")]
        [Required(ErrorMessage = "El domicilio es requerido")]
        public int Domicilio_Id { get; set; }

        [DisplayName("Role Id")]
        [Required(ErrorMessage = "El rol es requerido")]
        public int Role_Id { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public required string Nombre { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "El apellido es requerido")]
        public required string Apellido { get; set; }

        [DisplayName("Username")]
        [Required(ErrorMessage = "El nombre de usuario es requerido")]
        public required string Usuario { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "El email es requerido")]
        public string? Email { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "La contraseña es requerida")]
        public required string Pass { get; set; }

        [DisplayName("Active")]
        [Required(ErrorMessage = "El Estado es requerido")]
        public required string Baja { get; set; }
    }
}
