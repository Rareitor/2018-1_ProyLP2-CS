namespace Vista.Otros
{
    partial class FrmRecuperarContrasena
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblIngreseCorreo = new System.Windows.Forms.Label();
            this.btnRecuperarContra = new System.Windows.Forms.Button();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(201, 41);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(338, 23);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblIngreseCorreo
            // 
            this.lblIngreseCorreo.AutoSize = true;
            this.lblIngreseCorreo.Cursor = System.Windows.Forms.Cursors.No;
            this.lblIngreseCorreo.Location = new System.Drawing.Point(62, 41);
            this.lblIngreseCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreseCorreo.Name = "lblIngreseCorreo";
            this.lblIngreseCorreo.Size = new System.Drawing.Size(131, 17);
            this.lblIngreseCorreo.TabIndex = 1;
            this.lblIngreseCorreo.Text = "Ingrese su Usuario:";
            this.lblIngreseCorreo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRecuperarContra
            // 
            this.btnRecuperarContra.Location = new System.Drawing.Point(345, 87);
            this.btnRecuperarContra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecuperarContra.Name = "btnRecuperarContra";
            this.btnRecuperarContra.Size = new System.Drawing.Size(196, 28);
            this.btnRecuperarContra.TabIndex = 2;
            this.btnRecuperarContra.Text = "Recuperar Contraseña";
            this.btnRecuperarContra.UseVisualStyleBackColor = true;
            this.btnRecuperarContra.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRespuesta.Location = new System.Drawing.Point(39, 87);
            this.txtRespuesta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRespuesta.Multiline = true;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.ReadOnly = true;
            this.txtRespuesta.Size = new System.Drawing.Size(272, 94);
            this.txtRespuesta.TabIndex = 4;
            this.txtRespuesta.Text = " ";
            // 
            // FrmRecuperarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 208);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.btnRecuperarContra);
            this.Controls.Add(this.lblIngreseCorreo);
            this.Controls.Add(this.txtUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmRecuperarContrasena";
            this.Text = "Recuperar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblIngreseCorreo;
        private System.Windows.Forms.Button btnRecuperarContra;
        private System.Windows.Forms.TextBox txtRespuesta;
    }
}