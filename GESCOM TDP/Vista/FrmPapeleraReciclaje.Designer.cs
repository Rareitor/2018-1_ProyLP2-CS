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
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.id_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_eliminacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemBorrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picPapelera = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRecuperarProducto = new System.Windows.Forms.Button();
            this.btnRecuperarUsuario = new System.Windows.Forms.Button();
            this.btnRecuperarOrden = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPapelera)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Usuario,
            this.Fecha_eliminacion,
            this.ItemBorrado});
            this.dgvRegistro.Location = new System.Drawing.Point(98, 214);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.Size = new System.Drawing.Size(383, 156);
            this.dgvRegistro.TabIndex = 0;
            this.dgvRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_Usuario
            // 
            this.id_Usuario.HeaderText = "Id_Usuario";
            this.id_Usuario.Name = "id_Usuario";
            // 
            // Fecha_eliminacion
            // 
            this.Fecha_eliminacion.HeaderText = "Fecha_borrada";
            this.Fecha_eliminacion.Name = "Fecha_eliminacion";
            // 
            // ItemBorrado
            // 
            this.ItemBorrado.HeaderText = "Item_Borrado";
            this.ItemBorrado.Name = "ItemBorrado";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(196, 71);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(250, 20);
            this.dtpFechaInicio.TabIndex = 1;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(196, 110);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(250, 20);
            this.dtpFechaFin.TabIndex = 2;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(95, 77);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(83, 16);
            this.lblFechaInicio.TabIndex = 3;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(95, 116);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(70, 16);
            this.lblFechaFin.TabIndex = 4;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Los siguientes usuarios han realizado eliminaciones:";
            // 
            // picPapelera
            // 
            this.picPapelera.Image = ((System.Drawing.Image)(resources.GetObject("picPapelera.Image")));
            this.picPapelera.Location = new System.Drawing.Point(782, 110);
            this.picPapelera.Name = "picPapelera";
            this.picPapelera.Size = new System.Drawing.Size(192, 178);
            this.picPapelera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPapelera.TabIndex = 8;
            this.picPapelera.TabStop = false;
            this.picPapelera.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(941, 356);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Regresar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnRecuperarProducto);
            this.panel1.Controls.Add(this.btnRecuperarUsuario);
            this.panel1.Controls.Add(this.btnRecuperarOrden);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 44);
            this.panel1.TabIndex = 47;
            // 
            // btnRecuperarProducto
            // 
            this.btnRecuperarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRecuperarProducto.ForeColor = System.Drawing.Color.White;
            this.btnRecuperarProducto.Location = new System.Drawing.Point(362, 3);
            this.btnRecuperarProducto.Name = "btnRecuperarProducto";
            this.btnRecuperarProducto.Size = new System.Drawing.Size(363, 38);
            this.btnRecuperarProducto.TabIndex = 1;
            this.btnRecuperarProducto.Text = "Producto";
            this.btnRecuperarProducto.UseVisualStyleBackColor = false;
            this.btnRecuperarProducto.Click += new System.EventHandler(this.btnRecuperarProducto_Click);
            // 
            // btnRecuperarUsuario
            // 
            this.btnRecuperarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRecuperarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnRecuperarUsuario.Location = new System.Drawing.Point(0, 3);
            this.btnRecuperarUsuario.Name = "btnRecuperarUsuario";
            this.btnRecuperarUsuario.Size = new System.Drawing.Size(363, 38);
            this.btnRecuperarUsuario.TabIndex = 0;
            this.btnRecuperarUsuario.Text = "Usuario";
            this.btnRecuperarUsuario.UseVisualStyleBackColor = false;
            this.btnRecuperarUsuario.Click += new System.EventHandler(this.btnRecuperarUsuario_Click);
            // 
            // btnRecuperarOrden
            // 
            this.btnRecuperarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRecuperarOrden.ForeColor = System.Drawing.Color.White;
            this.btnRecuperarOrden.Location = new System.Drawing.Point(724, 3);
            this.btnRecuperarOrden.Name = "btnRecuperarOrden";
            this.btnRecuperarOrden.Size = new System.Drawing.Size(363, 38);
            this.btnRecuperarOrden.TabIndex = 2;
            this.btnRecuperarOrden.Text = "Orden";
            this.btnRecuperarOrden.UseVisualStyleBackColor = false;
            // 
            // FrmPapeleraReciclaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 408);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.picPapelera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.dgvRegistro);
            this.Name = "FrmPapeleraReciclaje";
            this.Text = "Papelera Reciclaje";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPapelera)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_eliminacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemBorrado;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picPapelera;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRecuperarOrden;
        private System.Windows.Forms.Button btnRecuperarProducto;
        private System.Windows.Forms.Button btnRecuperarUsuario;
    }
}