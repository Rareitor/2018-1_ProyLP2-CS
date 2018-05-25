namespace Vista.Otros
{
    partial class FrmVisualizarMapa
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
            this.lblDistrito = new System.Windows.Forms.Label();
            this.cmbDistrito = new System.Windows.Forms.ComboBox();
            this.dgvMapa = new System.Windows.Forms.DataGridView();
            this.idDistrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Location = new System.Drawing.Point(12, 21);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(107, 13);
            this.lblDistrito.TabIndex = 0;
            this.lblDistrito.Text = "Seleccione el distrito:";
            // 
            // cmbDistrito
            // 
            this.cmbDistrito.FormattingEnabled = true;
            this.cmbDistrito.Location = new System.Drawing.Point(138, 13);
            this.cmbDistrito.Name = "cmbDistrito";
            this.cmbDistrito.Size = new System.Drawing.Size(121, 21);
            this.cmbDistrito.TabIndex = 1;
            // 
            // dgvMapa
            // 
            this.dgvMapa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMapa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDistrito,
            this.nivelComision,
            this.tipoComision});
            this.dgvMapa.Location = new System.Drawing.Point(15, 63);
            this.dgvMapa.Name = "dgvMapa";
            this.dgvMapa.Size = new System.Drawing.Size(452, 150);
            this.dgvMapa.TabIndex = 2;
            // 
            // idDistrito
            // 
            this.idDistrito.HeaderText = "idDistrito";
            this.idDistrito.Name = "idDistrito";
            // 
            // nivelComision
            // 
            this.nivelComision.HeaderText = "nivelComision";
            this.nivelComision.Name = "nivelComision";
            // 
            // tipoComision
            // 
            this.tipoComision.HeaderText = "tipoComision";
            this.tipoComision.Name = "tipoComision";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(293, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // FrmVisualizarMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 287);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvMapa);
            this.Controls.Add(this.cmbDistrito);
            this.Controls.Add(this.lblDistrito);
            this.Name = "FrmVisualizarMapa";
            this.Text = "Visualizar Mapa";
            this.Load += new System.EventHandler(this.VisualizarMapa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.ComboBox cmbDistrito;
        private System.Windows.Forms.DataGridView dgvMapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDistrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoComision;
        private System.Windows.Forms.Button btnBuscar;
    }
}