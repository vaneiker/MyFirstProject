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

namespace Crud2.View.PlanView
{
    public partial class ListadoPlanView : Form
    {
        public ListadoPlanView()
        {
            InitializeComponent();
        }

        private void ListadoPlanView_Load(object sender, EventArgs e)
        {
            ListaPlan();
        }

        private void ListaPlan()
        {
            var resultado = CrudPlan.ListaPlanes();

            dataGridView_Plan.DataSource = resultado;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizaPantalla_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_Plan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
