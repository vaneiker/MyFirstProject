using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioMetodos.Models
{
    public class Departamento
    {
        public int IdDepartamento { get; set; }
        public string NombreDepartamento { get; set; }
        public string Extencion { get; set; }
        public string Responsable { get; set; }
        public string Objetivo { get; set; }
        public int NumeroEmpleados { get; set; }
        public decimal Presupuesto { get; set; }
        public bool Estatus { get; set; }
        public string UsuarioCrea { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string HostName { get; set; }
    }

}
