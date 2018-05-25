namespace Vista
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.labelBienvenido = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.linkOlvideContrasena = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelBienvenido
            // 
            this.labelBienvenido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBienvenido.AutoSize = true;
            this.labelBienvenido.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenido.Location = new System.Drawing.Point(281, 51);
            this.labelBienvenido.Name = "labelBienvenido";
            this.labelBienvenido.Size = new System.Drawing.Size(271, 29);
            this.labelBienvenido.TabIndex = 0;
            this.labelBienvenido.Text = "Bienvenido al sistema";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(308, 93);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(208, 34);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "GESCOM TDP";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsuario.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxUsuario.Location = new System.Drawing.Point(416, 168);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsuario.TabIndex = 2;
            this.textBoxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsuario_KeyPress);
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxContrasena.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxContrasena.Location = new System.Drawing.Point(416, 220);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.Size = new System.Drawing.Size(100, 20);
            this.textBoxContrasena.TabIndex = 3;
            this.textBoxContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxContrasena_KeyPress);
            // 
            // labelUsuario
            // 
            this.labelUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(300, 167);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(64, 18);
            this.labelUsuario.TabIndex = 4;
            this.labelUsuario.Text = "Usuario:";
            // 
            // labelContrasena
            // 
            this.labelContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelContrasena.AutoSize = true;
            this.labelContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasena.Location = new System.Drawing.Point(300, 220);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(89, 18);
            this.labelContrasena.TabIndex = 5;
            this.labelContrasena.Text = "Contraseña:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.Location = new System.Drawing.Point(340, 267);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(138, 23);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Iniciar sesión";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // linkOlvideContrasena
            // 
            this.linkOlvideContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkOlvideContrasena.AutoSize = true;
            this.linkOlvideContrasena.BackColor = System.Drawing.Color.Transparent;
            this.linkOlvideContrasena.Location = new System.Drawing.Point(337, 336);
            this.linkOlvideContrasena.Name = "linkOlvideContrasena";
            this.linkOlvideContrasena.Size = new System.Drawing.Size(151, 13);
            this.linkOlvideContrasena.TabIndex = 7;
            this.linkOlvideContrasena.TabStop = true;
            this.linkOlvideContrasena.Text = "¿Has olvidado la contraseña? ";
            this.linkOlvideContrasena.UseWaitCursor = true;
            this.linkOlvideContrasena.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOlvideContrasena_LinkClicked);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkOlvideContrasena);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelContrasena);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.textBoxContrasena);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelBienvenido);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBienvenido;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContrasena;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.LinkLabel linkOlvideContrasena;
    }
}

