using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioMetodos.Models
{
    public class Planes
    { 
        public int PlanID { get; set; }
        public string NombrePlan { get; set; }
        public string VelocidadMbps { get; set; } 
        public decimal? PrecioMensual { get; set; } 
        public string Estatus { get; set; }
    }
}
