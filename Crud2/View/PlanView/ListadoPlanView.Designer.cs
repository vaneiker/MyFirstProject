namespace Crud2.View.PlanView
{
    partial class ListadoPlanView
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
            this.dataGridView_Plan = new System.Windows.Forms.DataGridView();
            this.BtnVer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnActualizaPantalla = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Plan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Plan
            // 
            this.dataGridView_Plan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Plan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnVer,
            this.BtnEditar,
            this.btnBorrar});
            this.dataGridView_Plan.Location = new System.Drawing.Point(12, 132);
            this.dataGridView_Plan.Name = "dataGridView_Plan";
            this.dataGridView_Plan.Size = new System.Drawing.Size(778, 306);
            this.dataGridView_Plan.TabIndex = 0;
            this.dataGridView_Plan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Plan_CellContentClick);
            // 
            // BtnVer
            // 
            this.BtnVer.HeaderText = "Ver";
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Text = "Ver";
            this.BtnVer.ToolTipText = "Ver";
            this.BtnVer.UseColumnTextForButtonValue = true;
            this.BtnVer.Width = 50;
            // 
            // BtnEditar
            // 
            this.BtnEditar.HeaderText = "Editar";
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.ToolTipText = "Editar";
            this.BtnEditar.UseColumnTextForButtonValue = true;
            this.BtnEditar.Width = 50;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "Borrar";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.ToolTipText = "Borrar";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            this.btnBorrar.Width = 50;
            // 
            // btnActualizaPantalla
            // 
            this.btnActualizaPantalla.Location = new System.Drawing.Point(94, 94);
            this.btnActualizaPantalla.Name = "btnActualizaPantalla";
            this.btnActualizaPantalla.Size = new System.Drawing.Size(131, 23);
            this.btnActualizaPantalla.TabIndex = 4;
            this.btnActualizaPantalla.Text = "Actualiza Pantalla";
            this.btnActualizaPantalla.UseVisualStyleBackColor = true;
            this.btnActualizaPantalla.Click += new System.EventHandler(this.btnActualizaPantalla_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(12, 94);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 3;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // ListadoPlanView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.btnActualizaPantalla);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dataGridView_Plan);
            this.Name = "ListadoPlanView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoPlanView";
            this.Load += new System.EventHandler(this.ListadoPlanView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Plan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Plan;
        private System.Windows.Forms.DataGridViewButtonColumn BtnVer;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
        private System.Windows.Forms.Button btnActualizaPantalla;
        private System.Windows.Forms.Button btnnuevo;
    }
}