using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrincipioMetodos.Crud;
using PrincipioMetodos.Models;


namespace Crud2.View
{
    public partial class ListadoDepartamentoView : Form
    {

        public ListadoDepartamentoView()
        {
            InitializeComponent();
            
        }

        private void ListadoDepartamentoView_Load(object sender, EventArgs e)
        {
            ListaDepartamento();
        }

        private void ListaDepartamento()
        {
            var resultado = DepartamentoCrud.ListaDepartamento();

            dataGridView_Departamento.DataSource = resultado;
        }

        private void dataGridView_Departamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Departamento.CurrentRow != null)
            {
                if (e.ColumnIndex == 0)
                {

                    VerDepartamentoView departamento = new VerDepartamentoView(int.Parse(dataGridView_Departamento.CurrentRow.Cells["IdDepartamento"].Value.ToString()));
                    departamento.ShowDialog();

                    //this.id = int.Parse(dataGridView_Departamento.CurrentRow.Cells["IdDepartamento"].Value.ToString());

                }
                else if (e.ColumnIndex == 1)
                {

                    DepartamentoView departamento = new DepartamentoView(int.Parse(dataGridView_Departamento.CurrentRow.Cells["IdDepartamento"].Value.ToString()));
                    departamento.ShowDialog();

                    //this.id = int.Parse(dataGridView_Departamento.CurrentRow.Cells["IdDepartamento"].Value.ToString());

                }
                else if (e.ColumnIndex == 2)
                {

                    DialogResult resul = MessageBox.Show("Esta seguro que desea eliminar este Articulo?", "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resul == System.Windows.Forms.DialogResult.OK)
                    {

                        BorradoDepartamentoView departamento = new BorradoDepartamentoView(int.Parse(dataGridView_Departamento.CurrentRow.Cells["IdDepartamento"].Value.ToString()));
                        departamento.ShowDialog();



                        //var repuesta = _metodos.BorrarArticulo(int.Parse(this.codigo), false);


                        //DepartamentoCrud.InactivarDepartamento(new Departamento()
                        //{
                        //    IdDepartamento = int.Parse(dataGridView_Departamento.CurrentRow.Cells["IdDepartamento"].Value.ToString()),
                        //    UsuarioModifica = "ADMIN"
                        //});

                        //GetDepartamento();
                        //LimpiarAll();
                        //if (repuesta == true)
                        //{
                        //    Alertas.AlertSuccess trueR = new Alertas.AlertSuccess("Articulo Eliminado Satifactoriamente");
                        //    trueR.ShowDialog();
                        //    clearT();
                        //    carga();
                        //    Inactivar("Borrar");

                        //}
                        //else
                        //{
                        //    Alertas.AlertError falseR = new Alertas.AlertError("Articulo no fue Eliminado ");
                        //    falseR.ShowDialog();
                        //}

                    }
                }
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            DepartamentoView departamento = new DepartamentoView(0);
            departamento.ShowDialog();
        }

        private void btnActualizaPantalla_Click(object sender, EventArgs e)
        {
            ListaDepartamento();
             
        }
    }
}
