namespace Vista
{
    partial class FrmBusquedaUsuarioPersonalizada
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
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbApellidoPaterno = new System.Windows.Forms.ComboBox();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.cmbApellidoMaterno = new System.Windows.Forms.ComboBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.cmbCorreo = new System.Windows.Forms.ComboBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbDNI = new System.Windows.Forms.ComboBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.chckNombre = new System.Windows.Forms.CheckBox();
            this.chkApellidoPaterno = new System.Windows.Forms.CheckBox();
            this.chkApellidoMaterno = new System.Windows.Forms.CheckBox();
            this.chkCorreo = new System.Windows.Forms.CheckBox();
            this.chkDni = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmbNombre
            // 
            this.cmbNombre.Enabled = false;
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(156, 39);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(183, 21);
            this.cmbNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // cmbApellidoPaterno
            // 
            this.cmbApellidoPaterno.Enabled = false;
            this.cmbApellidoPaterno.FormattingEnabled = true;
            this.cmbApellidoPaterno.Location = new System.Drawing.Point(156, 74);
            this.cmbApellidoPaterno.Name = "cmbApellidoPaterno";
            this.cmbApellidoPaterno.Size = new System.Drawing.Size(183, 21);
            this.cmbApellidoPaterno.TabIndex = 5;
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(33, 77);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(87, 13);
            this.lblApellidoPaterno.TabIndex = 4;
            this.lblApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // cmbApellidoMaterno
            // 
            this.cmbApellidoMaterno.Enabled = false;
            this.cmbApellidoMaterno.FormattingEnabled = true;
            this.cmbApellidoMaterno.Location = new System.Drawing.Point(156, 113);
            this.cmbApellidoMaterno.Name = "cmbApellidoMaterno";
            this.cmbApellidoMaterno.Size = new System.Drawing.Size(183, 21);
            this.cmbApellidoMaterno.TabIndex = 7;
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(34, 116);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(89, 13);
            this.lblApellidoMaterno.TabIndex = 6;
            this.lblApellidoMaterno.Text = "Apellido Materno:";
            // 
            // cmbCorreo
            // 
            this.cmbCorreo.Enabled = false;
            this.cmbCorreo.FormattingEnabled = true;
            this.cmbCorreo.Location = new System.Drawing.Point(156, 156);
            this.cmbCorreo.Name = "cmbCorreo";
            this.cmbCorreo.Size = new System.Drawing.Size(183, 21);
            this.cmbCorreo.TabIndex = 9;
            this.cmbCorreo.SelectedIndexChanged += new System.EventHandler(this.cmbCorreo_SelectedIndexChanged);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(34, 159);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(41, 13);
            this.lblCorreo.TabIndex = 8;
            this.lblCorreo.Text = "Correo:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(127, 238);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 30);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbDNI
            // 
            this.cmbDNI.Enabled = false;
            this.cmbDNI.FormattingEnabled = true;
            this.cmbDNI.Location = new System.Drawing.Point(156, 196);
            this.cmbDNI.Name = "cmbDNI";
            this.cmbDNI.Size = new System.Drawing.Size(183, 21);
            this.cmbDNI.TabIndex = 12;
            this.cmbDNI.SelectedIndexChanged += new System.EventHandler(this.cmbDNI_SelectedIndexChanged);
            this.cmbDNI.Click += new System.EventHandler(this.cmbDNI_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(34, 199);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 11;
            this.lblDNI.Text = "Dni:";
            // 
            // chckNombre
            // 
            this.chckNombre.AutoSize = true;
            this.chckNombre.Location = new System.Drawing.Point(127, 42);
            this.chckNombre.Name = "chckNombre";
            this.chckNombre.Size = new System.Drawing.Size(15, 14);
            this.chckNombre.TabIndex = 13;
            this.chckNombre.UseVisualStyleBackColor = true;
            this.chckNombre.CheckedChanged += new System.EventHandler(this.chckNombre_CheckedChanged);
            // 
            // chkApellidoPaterno
            // 
            this.chkApellidoPaterno.AutoSize = true;
            this.chkApellidoPaterno.Location = new System.Drawing.Point(127, 81);
            this.chkApellidoPaterno.Name = "chkApellidoPaterno";
            this.chkApellidoPaterno.Size = new System.Drawing.Size(15, 14);
            this.chkApellidoPaterno.TabIndex = 14;
            this.chkApellidoPaterno.UseVisualStyleBackColor = true;
            this.chkApellidoPaterno.CheckedChanged += new System.EventHandler(this.chkApellidoPaterno_CheckedChanged);
            // 
            // chkApellidoMaterno
            // 
            this.chkApellidoMaterno.AutoSize = true;
            this.chkApellidoMaterno.Location = new System.Drawing.Point(127, 120);
            this.chkApellidoMaterno.Name = "chkApellidoMaterno";
            this.chkApellidoMaterno.Size = new System.Drawing.Size(15, 14);
            this.chkApellidoMaterno.TabIndex = 15;
            this.chkApellidoMaterno.UseVisualStyleBackColor = true;
            this.chkApellidoMaterno.CheckedChanged += new System.EventHandler(this.chkApellidoMaterno_CheckedChanged);
            // 
            // chkCorreo
            // 
            this.chkCorreo.AutoSize = true;
            this.chkCorreo.Location = new System.Drawing.Point(127, 161);
            this.chkCorreo.Name = "chkCorreo";
            this.chkCorreo.Size = new System.Drawing.Size(15, 14);
            this.chkCorreo.TabIndex = 16;
            this.chkCorreo.UseVisualStyleBackColor = true;
            this.chkCorreo.CheckedChanged += new System.EventHandler(this.chkCorreo_CheckedChanged);
            // 
            // chkDni
            // 
            this.chkDni.AutoSize = true;
            this.chkDni.Location = new System.Drawing.Point(127, 199);
            this.chkDni.Name = "chkDni";
            this.chkDni.Size = new System.Drawing.Size(15, 14);
            this.chkDni.TabIndex = 17;
            this.chkDni.UseVisualStyleBackColor = true;
            this.chkDni.CheckedChanged += new System.EventHandler(this.chkDni_CheckedChanged);
            // 
            // FrmBusquedaUsuarioPersonalizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 278);
            this.Controls.Add(this.chkDni);
            this.Controls.Add(this.chkCorreo);
            this.Controls.Add(this.chkApellidoMaterno);
            this.Controls.Add(this.chkApellidoPaterno);
            this.Controls.Add(this.chckNombre);
            this.Controls.Add(this.cmbDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.cmbApellidoMaterno);
            this.Controls.Add(this.lblApellidoMaterno);
            this.Controls.Add(this.cmbApellidoPaterno);
            this.Controls.Add(this.lblApellidoPaterno);
            this.Controls.Add(this.cmbNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmBusquedaUsuarioPersonalizada";
            this.Text = "Búsqueda Usuario Personalizada";
            this.Load += new System.EventHandler(this.FrmBusquedaUsuarioPersonalizada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbApellidoPaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.ComboBox cmbApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.ComboBox cmbCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.CheckBox chckNombre;
        private System.Windows.Forms.CheckBox chkApellidoPaterno;
        private System.Windows.Forms.CheckBox chkApellidoMaterno;
        private System.Windows.Forms.CheckBox chkCorreo;
        private System.Windows.Forms.CheckBox chkDni;
    }
}