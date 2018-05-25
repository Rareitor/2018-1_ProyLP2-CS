namespace Vista.Otros
{
    partial class FrmCambiarContraseña
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
            this.lblContrasenaNueva = new System.Windows.Forms.Label();
            this.lblConfirmarContrasena = new System.Windows.Forms.Label();
            this.txtContrasenaActual = new System.Windows.Forms.TextBox();
            this.txtContrasenaNueva = new System.Windows.Forms.TextBox();
            this.txtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chkVer = new System.Windows.Forms.CheckBox();
            this.lblContrasenaActual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblContrasenaNueva
            // 
            this.lblContrasenaNueva.AutoSize = true;
            this.lblContrasenaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenaNueva.Location = new System.Drawing.Point(82, 66);
            this.lblContrasenaNueva.Name = "lblContrasenaNueva";
            this.lblContrasenaNueva.Size = new System.Drawing.Size(102, 13);
            this.lblContrasenaNueva.TabIndex = 1;
            this.lblContrasenaNueva.Text = "Contraseña Nueva: ";
            // 
            // lblConfirmarContrasena
            // 
            this.lblConfirmarContrasena.AutoSize = true;
            this.lblConfirmarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContrasena.Location = new System.Drawing.Point(69, 109);
            this.lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            this.lblConfirmarContrasena.Size = new System.Drawing.Size(114, 13);
            this.lblConfirmarContrasena.TabIndex = 2;
            this.lblConfirmarContrasena.Text = "Confirmar Contraseña: ";
            // 
            // txtContrasenaActual
            // 
            this.txtContrasenaActual.Enabled = false;
            this.txtContrasenaActual.Location = new System.Drawing.Point(198, 23);
            this.txtContrasenaActual.Name = "txtContrasenaActual";
            this.txtContrasenaActual.Size = new System.Drawing.Size(100, 20);
            this.txtContrasenaActual.TabIndex = 3;
            // 
            // txtContrasenaNueva
            // 
            this.txtContrasenaNueva.Location = new System.Drawing.Point(198, 66);
            this.txtContrasenaNueva.Name = "txtContrasenaNueva";
            this.txtContrasenaNueva.Size = new System.Drawing.Size(100, 20);
            this.txtContrasenaNueva.TabIndex = 4;
            // 
            // txtConfirmarContrasena
            // 
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(198, 109);
            this.txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmarContrasena.TabIndex = 5;
            this.txtConfirmarContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(223, 161);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.Location = new System.Drawing.Point(72, 161);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkVer
            // 
            this.chkVer.AutoSize = true;
            this.chkVer.Location = new System.Drawing.Point(335, 25);
            this.chkVer.Name = "chkVer";
            this.chkVer.Size = new System.Drawing.Size(42, 17);
            this.chkVer.TabIndex = 19;
            this.chkVer.Text = "Ver";
            this.chkVer.UseVisualStyleBackColor = true;
            this.chkVer.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // lblContrasenaActual
            // 
            this.lblContrasenaActual.AutoSize = true;
            this.lblContrasenaActual.Location = new System.Drawing.Point(85, 23);
            this.lblContrasenaActual.Name = "lblContrasenaActual";
            this.lblContrasenaActual.Size = new System.Drawing.Size(97, 13);
            this.lblContrasenaActual.TabIndex = 20;
            this.lblContrasenaActual.Text = "Contraseña Actual:";
            // 
            // FrmCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 212);
            this.Controls.Add(this.lblContrasenaActual);
            this.Controls.Add(this.chkVer);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtConfirmarContrasena);
            this.Controls.Add(this.txtContrasenaNueva);
            this.Controls.Add(this.txtContrasenaActual);
            this.Controls.Add(this.lblConfirmarContrasena);
            this.Controls.Add(this.lblContrasenaNueva);
            this.Name = "FrmCambiarContraseña";
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.CambiarContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblContrasenaNueva;
        private System.Windows.Forms.Label lblConfirmarContrasena;
        private System.Windows.Forms.TextBox txtContrasenaActual;
        private System.Windows.Forms.TextBox txtContrasenaNueva;
        private System.Windows.Forms.TextBox txtConfirmarContrasena;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chkVer;
        private System.Windows.Forms.Label lblContrasenaActual;
    }
}