namespace Vista
{
    partial class FrmElegirTipoExportar
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
            this.lblIngreseTipoArch = new System.Windows.Forms.Label();
            this.pnlElegirTipoArch = new System.Windows.Forms.Panel();
            this.rdoExcel = new System.Windows.Forms.RadioButton();
            this.rdoPDF = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlElegirTipoArch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIngreseTipoArch
            // 
            this.lblIngreseTipoArch.AutoSize = true;
            this.lblIngreseTipoArch.Location = new System.Drawing.Point(12, 9);
            this.lblIngreseTipoArch.Name = "lblIngreseTipoArch";
            this.lblIngreseTipoArch.Size = new System.Drawing.Size(153, 13);
            this.lblIngreseTipoArch.TabIndex = 0;
            this.lblIngreseTipoArch.Text = "Ingrese tipo archivo a exportar:";
            // 
            // pnlElegirTipoArch
            // 
            this.pnlElegirTipoArch.Controls.Add(this.rdoPDF);
            this.pnlElegirTipoArch.Controls.Add(this.rdoExcel);
            this.pnlElegirTipoArch.Location = new System.Drawing.Point(34, 46);
            this.pnlElegirTipoArch.Name = "pnlElegirTipoArch";
            this.pnlElegirTipoArch.Size = new System.Drawing.Size(259, 53);
            this.pnlElegirTipoArch.TabIndex = 1;
            // 
            // rdoExcel
            // 
            this.rdoExcel.AutoSize = true;
            this.rdoExcel.Location = new System.Drawing.Point(29, 21);
            this.rdoExcel.Name = "rdoExcel";
            this.rdoExcel.Size = new System.Drawing.Size(51, 17);
            this.rdoExcel.TabIndex = 0;
            this.rdoExcel.TabStop = true;
            this.rdoExcel.Text = "Excel";
            this.rdoExcel.UseVisualStyleBackColor = true;
            // 
            // rdoPDF
            // 
            this.rdoPDF.AutoSize = true;
            this.rdoPDF.Location = new System.Drawing.Point(160, 21);
            this.rdoPDF.Name = "rdoPDF";
            this.rdoPDF.Size = new System.Drawing.Size(46, 17);
            this.rdoPDF.TabIndex = 1;
            this.rdoPDF.TabStop = true;
            this.rdoPDF.Text = "PDF";
            this.rdoPDF.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exportar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmElegirTipoExportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 170);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlElegirTipoArch);
            this.Controls.Add(this.lblIngreseTipoArch);
            this.Name = "FrmElegirTipoExportar";
            this.Text = "Exportar Datos";
            this.pnlElegirTipoArch.ResumeLayout(false);
            this.pnlElegirTipoArch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreseTipoArch;
        private System.Windows.Forms.Panel pnlElegirTipoArch;
        private System.Windows.Forms.RadioButton rdoPDF;
        private System.Windows.Forms.RadioButton rdoExcel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}