namespace Vista.Otros
{
    partial class FrmVisualizarCanalVenta
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
            this.cmbNombreCanal = new System.Windows.Forms.ComboBox();
            this.dgvCanalVenta = new System.Windows.Forms.DataGridView();
            this.idCanal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombreCanal = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanalVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNombreCanal
            // 
            this.cmbNombreCanal.FormattingEnabled = true;
            this.cmbNombreCanal.Location = new System.Drawing.Point(132, 19);
            this.cmbNombreCanal.Name = "cmbNombreCanal";
            this.cmbNombreCanal.Size = new System.Drawing.Size(143, 21);
            this.cmbNombreCanal.TabIndex = 0;
            // 
            // dgvCanalVenta
            // 
            this.dgvCanalVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanalVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCanal,
            this.nombre,
            this.responsable,
            this.zona});
            this.dgvCanalVenta.Location = new System.Drawing.Point(26, 128);
            this.dgvCanalVenta.Name = "dgvCanalVenta";
            this.dgvCanalVenta.Size = new System.Drawing.Size(514, 186);
            this.dgvCanalVenta.TabIndex = 1;
            // 
            // idCanal
            // 
            this.idCanal.HeaderText = "idCanal";
            this.idCanal.Name = "idCanal";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            // 
            // responsable
            // 
            this.responsable.HeaderText = "responsable";
            this.responsable.Name = "responsable";
            // 
            // zona
            // 
            this.zona.HeaderText = "zona";
            this.zona.Name = "zona";
            // 
            // lblNombreCanal
            // 
            this.lblNombreCanal.AutoSize = true;
            this.lblNombreCanal.Location = new System.Drawing.Point(23, 22);
            this.lblNombreCanal.Name = "lblNombreCanal";
            this.lblNombreCanal.Size = new System.Drawing.Size(91, 13);
            this.lblNombreCanal.TabIndex = 2;
            this.lblNombreCanal.Text = "Nombre de canal:";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(70, 62);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(44, 13);
            this.lblRegion.TabIndex = 4;
            this.lblRegion.Text = "Región:";
            this.lblRegion.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbRegion
            // 
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Location = new System.Drawing.Point(132, 54);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(143, 21);
            this.cmbRegion.TabIndex = 3;
            this.cmbRegion.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(305, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(465, 99);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(26, 99);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 8;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // FrmVisualizarCanalVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 358);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.cmbRegion);
            this.Controls.Add(this.lblNombreCanal);
            this.Controls.Add(this.dgvCanalVenta);
            this.Controls.Add(this.cmbNombreCanal);
            this.Name = "FrmVisualizarCanalVenta";
            this.Text = "Visualizar Canal Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanalVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNombreCanal;
        private System.Windows.Forms.DataGridView dgvCanalVenta;
        private System.Windows.Forms.Label lblNombreCanal;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.ComboBox cmbRegion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCanal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn zona;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}