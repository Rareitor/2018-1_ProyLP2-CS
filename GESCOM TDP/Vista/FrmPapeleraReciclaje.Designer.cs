namespace Vista.Otros
{
    partial class FrmPapeleraReciclaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPapeleraReciclaje));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblOrden = new System.Windows.Forms.Label();
            this.picOrden = new System.Windows.Forms.PictureBox();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(249, 332);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(89, 25);
            this.lblUsuario.TabIndex = 49;
            this.lblUsuario.Text = "Usuarios";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrden.Location = new System.Drawing.Point(685, 332);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(88, 25);
            this.lblOrden.TabIndex = 51;
            this.lblOrden.Text = "Órdenes";
            this.lblOrden.Click += new System.EventHandler(this.lblOrden_Click);
            // 
            // picOrden
            // 
            this.picOrden.Image = ((System.Drawing.Image)(resources.GetObject("picOrden.Image")));
            this.picOrden.Location = new System.Drawing.Point(624, 114);
            this.picOrden.Name = "picOrden";
            this.picOrden.Size = new System.Drawing.Size(213, 215);
            this.picOrden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOrden.TabIndex = 48;
            this.picOrden.TabStop = false;
            this.picOrden.Click += new System.EventHandler(this.picOrden_Click);
            // 
            // picUsuario
            // 
            this.picUsuario.Image = ((System.Drawing.Image)(resources.GetObject("picUsuario.Image")));
            this.picUsuario.Location = new System.Drawing.Point(194, 114);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(213, 215);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsuario.TabIndex = 46;
            this.picUsuario.TabStop = false;
            this.picUsuario.Click += new System.EventHandler(this.picUsuario_Click);
            // 
            // FrmPapeleraReciclaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 460);
            this.Controls.Add(this.lblOrden);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.picOrden);
            this.Controls.Add(this.picUsuario);
            this.Name = "FrmPapeleraReciclaje";
            this.Text = "Papelera Reciclaje";
            ((System.ComponentModel.ISupportInitialize)(this.picOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.PictureBox picOrden;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblOrden;
    }
}