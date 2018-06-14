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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsuario.Location = new System.Drawing.Point(42, 62);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(190, 23);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblIngreseCorreo
            // 
            this.lblIngreseCorreo.AutoSize = true;
            this.lblIngreseCorreo.Cursor = System.Windows.Forms.Cursors.No;
            this.lblIngreseCorreo.Location = new System.Drawing.Point(39, 32);
            this.lblIngreseCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreseCorreo.Name = "lblIngreseCorreo";
            this.lblIngreseCorreo.Size = new System.Drawing.Size(316, 17);
            this.lblIngreseCorreo.TabIndex = 1;
            this.lblIngreseCorreo.Text = "Ingresa tu usuario para recuperar tu contraseña.";
            this.lblIngreseCorreo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRecuperarContra
            // 
            this.btnRecuperarContra.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRecuperarContra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRecuperarContra.Location = new System.Drawing.Point(183, 126);
            this.btnRecuperarContra.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecuperarContra.Name = "btnRecuperarContra";
            this.btnRecuperarContra.Size = new System.Drawing.Size(88, 28);
            this.btnRecuperarContra.TabIndex = 2;
            this.btnRecuperarContra.Text = "Recuperar";
            this.btnRecuperarContra.UseVisualStyleBackColor = false;
            this.btnRecuperarContra.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRespuesta.Location = new System.Drawing.Point(42, 162);
            this.txtRespuesta.Margin = new System.Windows.Forms.Padding(4);
            this.txtRespuesta.Multiline = true;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.ReadOnly = true;
            this.txtRespuesta.Size = new System.Drawing.Size(314, 10);
            this.txtRespuesta.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(279, 126);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmRecuperarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 167);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.btnRecuperarContra);
            this.Controls.Add(this.lblIngreseCorreo);
            this.Controls.Add(this.txtUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button button1;
    }
}