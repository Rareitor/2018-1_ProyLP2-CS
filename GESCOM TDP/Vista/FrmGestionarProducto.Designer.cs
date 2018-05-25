namespace Vista
{
    partial class FrmGestionarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarProducto));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAnadir = new System.Windows.Forms.ToolStripButton();
            this.tsbtnModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlIngreseDato = new System.Windows.Forms.Panel();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIngreseCampo = new System.Windows.Forms.Label();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnBusquedaPer = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExportar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.pnlIngreseDato.SuspendLayout();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.Nombre,
            this.Marca,
            this.PrecioUnitario});
            this.dgvUsuarios.Location = new System.Drawing.Point(49, 156);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(567, 326);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellContentClick);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.Width = 70;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 120;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.Width = 80;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 23);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAnadir,
            this.tsbtnModificar,
            this.tsbtnEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(29, 482);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAnadir
            // 
            this.tsbtnAnadir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAnadir.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAnadir.Image")));
            this.tsbtnAnadir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAnadir.Name = "tsbtnAnadir";
            this.tsbtnAnadir.Size = new System.Drawing.Size(26, 27);
            this.tsbtnAnadir.Text = "toolStripButton1";
            this.tsbtnAnadir.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbtnModificar
            // 
            this.tsbtnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnModificar.Image")));
            this.tsbtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnModificar.Name = "tsbtnModificar";
            this.tsbtnModificar.Size = new System.Drawing.Size(26, 27);
            this.tsbtnModificar.Text = "toolStripButton4";
            this.tsbtnModificar.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tsbtnEliminar
            // 
            this.tsbtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEliminar.Image")));
            this.tsbtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEliminar.Name = "tsbtnEliminar";
            this.tsbtnEliminar.Size = new System.Drawing.Size(26, 27);
            this.tsbtnEliminar.Text = "toolStripButton3";
            this.tsbtnEliminar.Click += new System.EventHandler(this.tsbtnEliminar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegresar.Location = new System.Drawing.Point(585, 50);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(62, 23);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(412, 107);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnlIngreseDato
            // 
            this.pnlIngreseDato.Controls.Add(this.txtDato);
            this.pnlIngreseDato.Controls.Add(this.label2);
            this.pnlIngreseDato.Location = new System.Drawing.Point(49, 55);
            this.pnlIngreseDato.Name = "pnlIngreseDato";
            this.pnlIngreseDato.Size = new System.Drawing.Size(346, 95);
            this.pnlIngreseDato.TabIndex = 33;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(3, 55);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(278, 20);
            this.txtDato.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese dato";
            // 
            // lblIngreseCampo
            // 
            this.lblIngreseCampo.AutoSize = true;
            this.lblIngreseCampo.Location = new System.Drawing.Point(46, 34);
            this.lblIngreseCampo.Name = "lblIngreseCampo";
            this.lblIngreseCampo.Size = new System.Drawing.Size(121, 13);
            this.lblIngreseCampo.TabIndex = 32;
            this.lblIngreseCampo.Text = "Ingrese campo a buscar";
            // 
            // cmbCampo
            // 
            this.cmbCampo.AutoCompleteCustomSource.AddRange(new string[] {
            "idProducto",
            "Nombre",
            "Marca",
            "Precio Unitario"});
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Items.AddRange(new object[] {
            "idOrden",
            "Fecha",
            "Canal",
            "idComisionista",
            "Monto Retribución"});
            this.cmbCampo.Location = new System.Drawing.Point(206, 28);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(121, 21);
            this.cmbCampo.TabIndex = 30;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnBusquedaPer,
            this.tsbtnExportar});
            this.tsMenu.Location = new System.Drawing.Point(29, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(652, 25);
            this.tsMenu.TabIndex = 36;
            this.tsMenu.Text = "toolStrip2";
            // 
            // tsbtnBusquedaPer
            // 
            this.tsbtnBusquedaPer.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnBusquedaPer.Image")));
            this.tsbtnBusquedaPer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBusquedaPer.Name = "tsbtnBusquedaPer";
            this.tsbtnBusquedaPer.Size = new System.Drawing.Size(133, 22);
            this.tsbtnBusquedaPer.Text = "Busqueda Avanzada";
            this.tsbtnBusquedaPer.Click += new System.EventHandler(this.tsbtnBusquedaPer_Click);
            // 
            // tsbtnExportar
            // 
            this.tsbtnExportar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExportar.Image")));
            this.tsbtnExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExportar.Name = "tsbtnExportar";
            this.tsbtnExportar.Size = new System.Drawing.Size(70, 22);
            this.tsbtnExportar.Text = "Exportar";
            this.tsbtnExportar.Click += new System.EventHandler(this.tsbtnExportar_Click);
            // 
            // FrmGestionarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 482);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pnlIngreseDato);
            this.Controls.Add(this.lblIngreseCampo);
            this.Controls.Add(this.cmbCampo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "FrmGestionarProducto";
            this.Text = "Gestionar Productos";
            this.Load += new System.EventHandler(this.GestionarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlIngreseDato.ResumeLayout(false);
            this.pnlIngreseDato.PerformLayout();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAnadir;
        private System.Windows.Forms.ToolStripButton tsbtnModificar;
        private System.Windows.Forms.ToolStripButton tsbtnEliminar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pnlIngreseDato;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIngreseCampo;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbtnBusquedaPer;
        private System.Windows.Forms.ToolStripButton tsbtnExportar;
    }
}