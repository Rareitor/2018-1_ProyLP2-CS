namespace Vista
{
    partial class FrmRanking
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
            this.lblMejores = new System.Windows.Forms.Label();
            this.dgvRanking = new System.Windows.Forms.DataGridView();
            this.idPayee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePayee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMejores
            // 
            this.lblMejores.AutoSize = true;
            this.lblMejores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMejores.Location = new System.Drawing.Point(48, 23);
            this.lblMejores.Name = "lblMejores";
            this.lblMejores.Size = new System.Drawing.Size(318, 24);
            this.lblMejores.TabIndex = 0;
            this.lblMejores.Text = "Los 3 mejores comisionistas son:";
            // 
            // dgvRanking
            // 
            this.dgvRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRanking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPayee,
            this.NombrePayee,
            this.ApellidoPaterno,
            this.MontoTotal});
            this.dgvRanking.Location = new System.Drawing.Point(52, 62);
            this.dgvRanking.Name = "dgvRanking";
            this.dgvRanking.Size = new System.Drawing.Size(630, 277);
            this.dgvRanking.TabIndex = 1;
            this.dgvRanking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRanking_CellContentClick);
            // 
            // idPayee
            // 
            this.idPayee.DataPropertyName = "IdTrabajador";
            this.idPayee.HeaderText = "ID";
            this.idPayee.Name = "idPayee";
            // 
            // NombrePayee
            // 
            this.NombrePayee.DataPropertyName = "Nombre";
            this.NombrePayee.HeaderText = "Nombre";
            this.NombrePayee.Name = "NombrePayee";
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.DataPropertyName = "ApellidoPaterno";
            this.ApellidoPaterno.HeaderText = "Apellido Paterno";
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            // 
            // MontoTotal
            // 
            this.MontoTotal.DataPropertyName = "Monto";
            this.MontoTotal.HeaderText = "Monto";
            this.MontoTotal.Name = "MontoTotal";
            // 
            // FrmRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRanking);
            this.Controls.Add(this.lblMejores);
            this.Name = "FrmRanking";
            this.Text = "FrmRanking";
            this.Load += new System.EventHandler(this.FrmRanking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMejores;
        private System.Windows.Forms.DataGridView dgvRanking;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPayee;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePayee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
    }
}