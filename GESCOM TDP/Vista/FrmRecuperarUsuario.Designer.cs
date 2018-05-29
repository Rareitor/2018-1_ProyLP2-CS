namespace Vista
{
    partial class FrmRecuperarUsuario
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
            this.dgvUsuariosRec = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosRec)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuariosRec
            // 
            this.dgvUsuariosRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosRec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DNI,
            this.Nombre,
            this.Apellido_Paterno,
            this.Apellido_Materno});
            this.dgvUsuariosRec.Location = new System.Drawing.Point(42, 88);
            this.dgvUsuariosRec.Name = "dgvUsuariosRec";
            this.dgvUsuariosRec.Size = new System.Drawing.Size(510, 252);
            this.dgvUsuariosRec.TabIndex = 0;
            this.dgvUsuariosRec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuariosRec_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IdTrabajador";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "Dni";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido_Paterno
            // 
            this.Apellido_Paterno.DataPropertyName = "ApellidoPaterno";
            this.Apellido_Paterno.HeaderText = "Apellido Paterno";
            this.Apellido_Paterno.Name = "Apellido_Paterno";
            // 
            // Apellido_Materno
            // 
            this.Apellido_Materno.DataPropertyName = "ApellidoMaterno";
            this.Apellido_Materno.HeaderText = "Apellido Materno";
            this.Apellido_Materno.Name = "Apellido_Materno";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(522, 27);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(639, 26);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmRecuperarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvUsuariosRec);
            this.Name = "FrmRecuperarUsuario";
            this.Text = "FrmRecuperarUsuario";
            this.Load += new System.EventHandler(this.FrmRecuperarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosRec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuariosRec;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Materno;
    }
}