using PrincipioMetodos.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud2.View
{
    public partial class VerDepartamentoView : Form
    {
        private int _IdDepartamento { get; set; }
        private int Id { get; set; }
        public VerDepartamentoView(int IdDepartamento = 0)
        {
            _IdDepartamento = IdDepartamento;
            InitializeComponent();
        }

        private void VerDepartamentoView_Load(object sender, EventArgs e)
        {
            CargarDepartamento();
        }

        private void CargarDepartamento()
        {
            var resultado = DepartamentoCrud.ListaDepartamento();

            var obj = resultado.Where(x => x.IdDepartamento == _IdDepartamento).FirstOrDefault();

            if (obj != null)
            {
                lblNombreDepartamento.Text = obj.NombreDepartamento;
                lblExtencion.Text = obj.Extencion;
                lblPresupuesto.Text = obj.Presupuesto.ToString();
                lblNumeroEmpleado.Text = obj.NumeroEmpleados.ToString();
                lblResponsable.Text = obj.Responsable.ToString();
                lblObjectivo.Text = obj.Objetivo.ToString();
                
                 
              
            }
            else
            {
                lblNombreDepartamento.Text ="Sin datos para mostrar";
                lblExtencion.Text = "Sin datos para mostrar";
                lblPresupuesto.Text = "Sin datos para mostrar";
                lblNumeroEmpleado.Text = "Sin datos para mostrar";
                lblResponsable.Text = "Sin datos para mostrar";
                lblObjectivo.Text = "Sin datos para mostrar";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
