namespace Crud2.View
{
    partial class ListadoDepartamentoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_Departamento = new System.Windows.Forms.DataGridView();
            this.btnVerDepartamento = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnActualizaPantalla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Departamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Departamento
            // 
            this.dataGridView_Departamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Departamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnVerDepartamento,
            this.btnEditar,
            this.btnBorrar});
            this.dataGridView_Departamento.Location = new System.Drawing.Point(13, 146);
            this.dataGridView_Departamento.Name = "dataGridView_Departamento";
            this.dataGridView_Departamento.Size = new System.Drawing.Size(775, 292);
            this.dataGridView_Departamento.TabIndex = 0;
            this.dataGridView_Departamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Departamento_CellContentClick);
            // 
            // btnVerDepartamento
            // 
            this.btnVerDepartamento.HeaderText = "Ver";
            this.btnVerDepartamento.Name = "btnVerDepartamento";
            this.btnVerDepartamento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnVerDepartamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnVerDepartamento.Text = "Ver";
            this.btnVerDepartamento.ToolTipText = "Ver";
            this.btnVerDepartamento.UseColumnTextForButtonValue = true;
            this.btnVerDepartamento.Width = 50;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 50;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "Borrar";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            this.btnBorrar.Width = 50;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(13, 113);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 1;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnActualizaPantalla
            // 
            this.btnActualizaPantalla.Location = new System.Drawing.Point(95, 113);
            this.btnActualizaPantalla.Name = "btnActualizaPantalla";
            this.btnActualizaPantalla.Size = new System.Drawing.Size(131, 23);
            this.btnActualizaPantalla.TabIndex = 2;
            this.btnActualizaPantalla.Text = "Actualiza Pantalla";
            this.btnActualizaPantalla.UseVisualStyleBackColor = true;
            this.btnActualizaPantalla.Click += new System.EventHandler(this.btnActualizaPantalla_Click);
            // 
            // ListadoDepartamentoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizaPantalla);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dataGridView_Departamento);
            this.Name = "ListadoDepartamentoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoDepartamentoView";
            this.Load += new System.EventHandler(this.ListadoDepartamentoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Departamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Departamento;
        private System.Windows.Forms.DataGridViewButtonColumn btnVerDepartamento;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnActualizaPantalla;
    }
}