namespace Vista.Otros
{
    partial class FrmVisualizarUsuario
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
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.pnlIngreseDato = new System.Windows.Forms.Panel();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIngreseCampo = new System.Windows.Forms.Label();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlIngreseDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(662, 132);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 4;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // pnlIngreseDato
            // 
            this.pnlIngreseDato.Controls.Add(this.txtDato);
            this.pnlIngreseDato.Controls.Add(this.label2);
            this.pnlIngreseDato.Location = new System.Drawing.Point(26, 55);
            this.pnlIngreseDato.Name = "pnlIngreseDato";
            this.pnlIngreseDato.Size = new System.Drawing.Size(346, 100);
            this.pnlIngreseDato.TabIndex = 27;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(32, 58);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(278, 20);
            this.txtDato.TabIndex = 1;
            this.txtDato.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDato_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese dato";
            // 
            // lblIngreseCampo
            // 
            this.lblIngreseCampo.AutoSize = true;
            this.lblIngreseCampo.Location = new System.Drawing.Point(23, 28);
            this.lblIngreseCampo.Name = "lblIngreseCampo";
            this.lblIngreseCampo.Size = new System.Drawing.Size(121, 13);
            this.lblIngreseCampo.TabIndex = 26;
            this.lblIngreseCampo.Text = "Ingrese campo a buscar";
            // 
            // cmbCampo
            // 
            this.cmbCampo.AutoCompleteCustomSource.AddRange(new string[] {
            "idUsuario",
            "Usuario",
            "Nombre",
            "Apellido Paterno",
            "Apellido Materno",
            "Correo",
            "Jefe Directo"});
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Items.AddRange(new object[] {
            "<Todos>",
            "idUsuario",
            "Nombre",
            "Apellido Paterno",
            "Apellido Materno",
            "Distrito"});
            this.cmbCampo.Location = new System.Drawing.Point(189, 25);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(121, 21);
            this.cmbCampo.TabIndex = 24;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.dni,
            this.nombre,
            this.apellidoPaterno,
            this.apellidoMaterno,
            this.email,
            this.username,
            this.distrito});
            this.dgvUsuarios.Location = new System.Drawing.Point(26, 177);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(881, 295);
            this.dgvUsuarios.TabIndex = 35;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(807, 132);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Regresar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // idUsuario
            // 
            this.idUsuario.DataPropertyName = "IdTrabajador";
            this.idUsuario.HeaderText = "ID";
            this.idUsuario.Name = "idUsuario";
            // 
            // dni
            // 
            this.dni.DataPropertyName = "Dni";
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellidoPaterno
            // 
            this.apellidoPaterno.DataPropertyName = "ApellidoPaterno";
            this.apellidoPaterno.HeaderText = "Apellido Paterno";
            this.apellidoPaterno.Name = "apellidoPaterno";
            // 
            // apellidoMaterno
            // 
            this.apellidoMaterno.DataPropertyName = "ApellidoMaterno";
            this.apellidoMaterno.HeaderText = "Apellido Materno";
            this.apellidoMaterno.Name = "apellidoMaterno";
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            // 
            // username
            // 
            this.username.DataPropertyName = "Username";
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            // 
            // distrito
            // 
            this.distrito.DataPropertyName = "Distrito";
            this.distrito.HeaderText = "Distrito";
            this.distrito.Name = "distrito";
            // 
            // FrmVisualizarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 484);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.pnlIngreseDato);
            this.Controls.Add(this.lblIngreseCampo);
            this.Controls.Add(this.cmbCampo);
            this.Controls.Add(this.btnSeleccionar);
            this.Name = "FrmVisualizarUsuario";
            this.Text = "Visualizar Comisionista";
            this.pnlIngreseDato.ResumeLayout(false);
            this.pnlIngreseDato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Panel pnlIngreseDato;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIngreseCampo;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn distrito;
    }
}