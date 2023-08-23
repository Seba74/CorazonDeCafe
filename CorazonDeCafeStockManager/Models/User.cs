using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorazonDeCafeStockManager
{
    internal class User
    {
        public int Id { get; set; }
        public int Domicilio_Id { get; set; }
        public int Role_Id { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string Usuario { get; set; }
        public string? Email { get; set; }
        public required string Pass { get; set; }
        public required string Baja { get; set; }
    }
}
