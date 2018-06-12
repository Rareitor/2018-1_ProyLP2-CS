namespace Vista.Otros
{
    partial class FrmNoticias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNoticias));
            this.lblNoticiasRecientes = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.picNoticias = new System.Windows.Forms.PictureBox();
            this.lBNoticias = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNoticias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoticiasRecientes
            // 
            this.lblNoticiasRecientes.AutoSize = true;
            this.lblNoticiasRecientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoticiasRecientes.Location = new System.Drawing.Point(20, 19);
            this.lblNoticiasRecientes.Name = "lblNoticiasRecientes";
            this.lblNoticiasRecientes.Size = new System.Drawing.Size(138, 20);
            this.lblNoticiasRecientes.TabIndex = 0;
            this.lblNoticiasRecientes.Text = "Noticias recientes:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegresar.Location = new System.Drawing.Point(806, 243);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(107, 23);
            this.btnRegresar.TabIndex = 16;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // picNoticias
            // 
            this.picNoticias.Image = ((System.Drawing.Image)(resources.GetObject("picNoticias.Image")));
            this.picNoticias.Location = new System.Drawing.Point(736, 77);
            this.picNoticias.Name = "picNoticias";
            this.picNoticias.Size = new System.Drawing.Size(155, 127);
            this.picNoticias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNoticias.TabIndex = 17;
            this.picNoticias.TabStop = false;
            // 
            // lBNoticias
            // 
            this.lBNoticias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lBNoticias.FormattingEnabled = true;
            this.lBNoticias.ItemHeight = 20;
            this.lBNoticias.Location = new System.Drawing.Point(50, 53);
            this.lBNoticias.Name = "lBNoticias";
            this.lBNoticias.Size = new System.Drawing.Size(654, 204);
            this.lBNoticias.TabIndex = 18;
            this.lBNoticias.Click += new System.EventHandler(this.lBNoticias_Click);
            this.lBNoticias.SelectedIndexChanged += new System.EventHandler(this.lBNoticias_SelectedIndexChanged);
            // 
            // FrmNoticias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 332);
            this.Controls.Add(this.lBNoticias);
            this.Controls.Add(this.picNoticias);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblNoticiasRecientes);
            this.Name = "FrmNoticias";
            this.Text = "Noticias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNoticias_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picNoticias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoticiasRecientes;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.PictureBox picNoticias;
        private System.Windows.Forms.ListBox lBNoticias;
    }
}