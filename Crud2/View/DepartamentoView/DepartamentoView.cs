using PrincipioMetodos.Crud;
using PrincipioMetodos.Models;
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
    public partial class DepartamentoView : Form
    {
        private int _IdDepartamento { get; set; }
        private int Id { get; set; }

        public DepartamentoView(int IdDepartamento = 0)
        {
            _IdDepartamento = IdDepartamento;
            InitializeComponent();
        }

        private void DepartamentoView_Load(object sender, EventArgs e)
        {
            CargarDepartamento();
        }

        private void CargarDepartamento()
        {
            var resultado = DepartamentoCrud.ListaDepartamento();

            var obj = resultado.Where(x => x.IdDepartamento == _IdDepartamento).FirstOrDefault();

            if (obj != null)
            {
                txtNombreDepartamento.Text = obj.NombreDepartamento;
                txtExtencion.Text = obj.Extencion;
                txtPresupuesto.Text = obj.Presupuesto.ToString();
                txtNumeroEmpleados.Text = obj.NumeroEmpleados.ToString();
                txtResponsable.Text = obj.Responsable.ToString();
                txtObjetivo.Text = obj.Objetivo.ToString();
                btnGuardar.Text = "Actualizar";
                this.Id = obj.IdDepartamento;
                lblTitulo.Text = "Actualizar Departamento";
            }
            else
            {
                txtNombreDepartamento.Text = string.Empty;
                txtExtencion.Text = string.Empty;
                txtPresupuesto.Text = string.Empty;
                txtNumeroEmpleados.Text = string.Empty;
                txtResponsable.Text = string.Empty;
                txtObjetivo.Text = string.Empty;
                btnGuardar.Text = "Guardar";
                this.Id = 0;
                lblTitulo.Text = "Guardar Departamento";

            }
        }

        private void LimpiarAll()
        {
            txtNombreDepartamento.Text = string.Empty;
            txtExtencion.Text = string.Empty;
            txtPresupuesto.Text = string.Empty;
            txtNumeroEmpleados.Text = string.Empty;
            txtResponsable.Text = string.Empty;
            txtObjetivo.Text = string.Empty;
            this.Id = 0;
            btnGuardar.Text = "Guardar";
            lblTitulo.Text = "Guardar Departamento";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var contenedor = new Departamento();

            contenedor.NombreDepartamento = txtNombreDepartamento.Text;
            contenedor.Extencion = txtExtencion.Text;
            contenedor.Responsable = txtResponsable.Text;
            contenedor.Objetivo = txtObjetivo.Text;
            contenedor.NumeroEmpleados = int.Parse(txtNumeroEmpleados.Text);
            contenedor.Presupuesto = decimal.Parse(txtPresupuesto.Text);
            contenedor.UsuarioCrea = "ADMIN";
            contenedor.IdDepartamento = this.Id;
            DepartamentoCrud.Create(contenedor);
            LimpiarAll();
        }
    }
}
