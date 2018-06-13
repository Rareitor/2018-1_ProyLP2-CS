namespace Vista.Otros
{
    partial class FrmRealizarBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRealizarBackup));
            this.lblIngreseUbicacion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dateIngreso = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIngreseUbicacion
            // 
            this.lblIngreseUbicacion.AutoSize = true;
            this.lblIngreseUbicacion.Location = new System.Drawing.Point(47, 60);
            this.lblIngreseUbicacion.Name = "lblIngreseUbicacion";
            this.lblIngreseUbicacion.Size = new System.Drawing.Size(68, 13);
            this.lblIngreseUbicacion.TabIndex = 2;
            this.lblIngreseUbicacion.Text = "Fecha límite:";
            this.lblIngreseUbicacion.Click += new System.EventHandler(this.lblIngreseUbicacion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(426, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(186, 98);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Registrar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dateIngreso
            // 
            this.dateIngreso.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dateIngreso.CustomFormat = "dd/MM/yyyy";
            this.dateIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateIngreso.Location = new System.Drawing.Point(135, 53);
            this.dateIngreso.Name = "dateIngreso";
            this.dateIngreso.Size = new System.Drawing.Size(257, 23);
            this.dateIngreso.TabIndex = 46;
            this.dateIngreso.ValueChanged += new System.EventHandler(this.dateIngreso_ValueChanged);
            // 
            // FrmRealizarBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 179);
            this.Controls.Add(this.dateIngreso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblIngreseUbicacion);
            this.Name = "FrmRealizarBackup";
            this.Text = "Mantenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreseUbicacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dateIngreso;
    }
}