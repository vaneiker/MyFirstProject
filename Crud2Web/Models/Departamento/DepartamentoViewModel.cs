using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud2Web.Models.Departamento
{
    public class DepartamentoViewModel
    {
        public int id { get; set; }
        public string Departamento { get; set; }
        public string Ext { get; set; }
        public string Representante { get; set; }
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