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
            this.Razón = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlIngreseDato = new System.Windows.Forms.Panel();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIngreseCampo = new System.Windows.Forms.Label();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosRec)).BeginInit();
            this.pnlIngreseDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuariosRec
            // 
            this.dgvUsuariosRec.AllowUserToOrderColumns = true;
            this.dgvUsuariosRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosRec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DNI,
            this.Nombre,
            this.Apellido_Paterno,
            this.Apellido_Materno,
            this.Razón});
            this.dgvUsuariosRec.Location = new System.Drawing.Point(35, 168);
            this.dgvUsuariosRec.Name = "dgvUsuariosRec";
            this.dgvUsuariosRec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUsuariosRec.Size = new System.Drawing.Size(648, 252);
            this.dgvUsuariosRec.TabIndex = 0;
            this.dgvUsuariosRec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuariosRec_CellContentClick);
            this.dgvUsuariosRec.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsuariosRec_ColumnHeaderMouseClick);
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
            // Razón
            // 
            this.Razón.DataPropertyName = "Razon";
            this.Razón.HeaderText = "Razón";
            this.Razón.Name = "Razón";
            this.Razón.Width = 105;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeleccionar.Location = new System.Drawing.Point(512, 442);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(602, 442);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlIngreseDato
            // 
            this.pnlIngreseDato.Controls.Add(this.txtDato);
            this.pnlIngreseDato.Controls.Add(this.label2);
            this.pnlIngreseDato.Location = new System.Drawing.Point(344, 62);
            this.pnlIngreseDato.Name = "pnlIngreseDato";
            this.pnlIngreseDato.Size = new System.Drawing.Size(339, 100);
            this.pnlIngreseDato.TabIndex = 28;
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
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese dato:";
            // 
            // lblIngreseCampo
            // 
            this.lblIngreseCampo.AutoSize = true;
            this.lblIngreseCampo.Location = new System.Drawing.Point(51, 122);
            this.lblIngreseCampo.Name = "lblIngreseCampo";
            this.lblIngreseCampo.Size = new System.Drawing.Size(121, 13);
            this.lblIngreseCampo.TabIndex = 30;
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
            "ID",
            "DNI",
            "Nombre",
            "Apellido Paterno",
            "Apellido Materno",
            "Razón"});
            this.cmbCampo.Location = new System.Drawing.Point(217, 119);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(121, 21);
            this.cmbCampo.TabIndex = 29;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(686, 39);
            this.label1.TabIndex = 31;
            this.label1.Text = "PAPELERA DE RECICLAJE USUARIOS";
            // 
            // FrmRecuperarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIngreseCampo);
            this.Controls.Add(this.cmbCampo);
            this.Controls.Add(this.pnlIngreseDato);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvUsuariosRec);
            this.Name = "FrmRecuperarUsuario";
            this.Text = "Recuperar Usuario";
            this.Load += new System.EventHandler(this.FrmRecuperarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosRec)).EndInit();
            this.pnlIngreseDato.ResumeLayout(false);
            this.pnlIngreseDato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridViewTextBoxColumn Razón;
        private System.Windows.Forms.Panel pnlIngreseDato;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIngreseCampo;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.Label label1;
    }
}