namespace Vista.Otros
{
    partial class FrmAñadirNoticia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAñadirNoticia));
            this.rtxNoticia = new System.Windows.Forms.RichTextBox();
            this.lblIngreseNoticia = new System.Windows.Forms.Label();
            this.picNoticia = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxTitulo = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.picNoticia)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxNoticia
            // 
            this.rtxNoticia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxNoticia.Location = new System.Drawing.Point(24, 134);
            this.rtxNoticia.MaxLength = 1500;
            this.rtxNoticia.Name = "rtxNoticia";
            this.rtxNoticia.Size = new System.Drawing.Size(528, 158);
            this.rtxNoticia.TabIndex = 0;
            this.rtxNoticia.Text = "";
            this.rtxNoticia.TextChanged += new System.EventHandler(this.rtxNoticia_TextChanged);
            // 
            // lblIngreseNoticia
            // 
            this.lblIngreseNoticia.AutoSize = true;
            this.lblIngreseNoticia.Location = new System.Drawing.Point(21, 106);
            this.lblIngreseNoticia.Name = "lblIngreseNoticia";
            this.lblIngreseNoticia.Size = new System.Drawing.Size(90, 13);
            this.lblIngreseNoticia.TabIndex = 19;
            this.lblIngreseNoticia.Text = "Ingrese la noticia:";
            // 
            // picNoticia
            // 
            this.picNoticia.Image = ((System.Drawing.Image)(resources.GetObject("picNoticia.Image")));
            this.picNoticia.Location = new System.Drawing.Point(596, 47);
            this.picNoticia.Name = "picNoticia";
            this.picNoticia.Size = new System.Drawing.Size(210, 147);
            this.picNoticia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNoticia.TabIndex = 20;
            this.picNoticia.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ingrese titulo:";
            // 
            // rtxTitulo
            // 
            this.rtxTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxTitulo.Location = new System.Drawing.Point(24, 47);
            this.rtxTitulo.MaxLength = 1500;
            this.rtxTitulo.Name = "rtxTitulo";
            this.rtxTitulo.Size = new System.Drawing.Size(528, 48);
            this.rtxTitulo.TabIndex = 22;
            this.rtxTitulo.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(818, 25);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.nuevoToolStripButton_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmAñadirNoticia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 306);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rtxTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picNoticia);
            this.Controls.Add(this.lblIngreseNoticia);
            this.Controls.Add(this.rtxNoticia);
            this.Name = "FrmAñadirNoticia";
            this.Text = "Añadir Noticias";
            this.Load += new System.EventHandler(this.AñadirNoticias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNoticia)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxNoticia;
        private System.Windows.Forms.Label lblIngreseNoticia;
        private System.Windows.Forms.PictureBox picNoticia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxTitulo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
    }
}