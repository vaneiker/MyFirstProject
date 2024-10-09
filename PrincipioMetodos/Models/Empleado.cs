using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioMetodos.Models
{
    public class Empleado
    {
        public int? IdEmpleado { get; set; }
        public decimal SueldoBruto { get; set; }
        public decimal Deduciones { get; set; }
        public decimal SueldoNeto { get; set; }
        public decimal ars { get; set; }
        public decimal afp { get; set; }
        public decimal isr { get; set; }
        public string Nombre { get; set; }
    }
}
