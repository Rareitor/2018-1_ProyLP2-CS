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
            this.btnDetalle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.picPapelera = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPapelera)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Usuario,
            this.Fecha_eliminacion,
            this.ItemBorrado});
            this.dgvRegistro.Location = new System.Drawing.Point(30, 106);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.Size = new System.Drawing.Size(373, 137);
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
            this.dtpFechaInicio.Location = new System.Drawing.Point(125, 12);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(250, 20);
            this.dtpFechaInicio.TabIndex = 1;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(125, 51);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(250, 20);
            this.dtpFechaFin.TabIndex = 2;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(24, 18);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(68, 13);
            this.lblFechaInicio.TabIndex = 3;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(24, 57);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(57, 13);
            this.lblFechaFin.TabIndex = 4;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(74, 260);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(123, 23);
            this.btnDetalle.TabIndex = 5;
            this.btnDetalle.Text = "Visualizar Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccione un registro:";
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(220, 260);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(134, 23);
            this.btnRecuperar.TabIndex = 7;
            this.btnRecuperar.Text = "Recuperar Información";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // picPapelera
            // 
            this.picPapelera.Image = ((System.Drawing.Image)(resources.GetObject("picPapelera.Image")));
            this.picPapelera.Location = new System.Drawing.Point(455, 71);
            this.picPapelera.Name = "picPapelera";
            this.picPapelera.Size = new System.Drawing.Size(183, 172);
            this.picPapelera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPapelera.TabIndex = 8;
            this.picPapelera.TabStop = false;
            this.picPapelera.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(586, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Regresar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmPapeleraReciclaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 302);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.picPapelera);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.dgvRegistro);
            this.Name = "FrmPapeleraReciclaje";
            this.Text = "Papelera Reciclaje";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPapelera)).EndInit();
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
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.PictureBox picPapelera;
        private System.Windows.Forms.Button btnCancelar;
    }
}