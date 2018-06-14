using System.Windows.Forms;

namespace Vista
{
    partial class FrmGestionarComboProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarComboProducto));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnImportar = new System.Windows.Forms.ToolStripButton();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.cmbCombo = new System.Windows.Forms.ComboBox();
            this.cmbCanal = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMesPeriodo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAñoPeriodo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbnComision = new System.Windows.Forms.RadioButton();
            this.rbnBono = new System.Windows.Forms.RadioButton();
            this.rbnPenalidad = new System.Windows.Forms.RadioButton();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnCancelar,
            this.btnImportar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(446, 25);
            this.tsMenu.TabIndex = 18;
            this.tsMenu.Text = "toolStrip2";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Image = ((System.Drawing.Image)(resources.GetObject("btnImportar.Image")));
            this.btnImportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(117, 22);
            this.btnImportar.Text = "Importar Archivo";
            this.btnImportar.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(166, 126);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(240, 23);
            this.cmbProducto.TabIndex = 27;
            // 
            // cmbCombo
            // 
            this.cmbCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCombo.FormattingEnabled = true;
            this.cmbCombo.Location = new System.Drawing.Point(166, 88);
            this.cmbCombo.Name = "cmbCombo";
            this.cmbCombo.Size = new System.Drawing.Size(240, 23);
            this.cmbCombo.TabIndex = 26;
            this.cmbCombo.SelectedIndexChanged += new System.EventHandler(this.cmbCombo_SelectedIndexChanged);
            // 
            // cmbCanal
            // 
            this.cmbCanal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCanal.FormattingEnabled = true;
            this.cmbCanal.Location = new System.Drawing.Point(166, 47);
            this.cmbCanal.Name = "cmbCanal";
            this.cmbCanal.Size = new System.Drawing.Size(240, 23);
            this.cmbCanal.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(14, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(14, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Combo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Canal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Periodo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(118, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Mes:";
            // 
            // cmbMesPeriodo
            // 
            this.cmbMesPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMesPeriodo.FormattingEnabled = true;
            this.cmbMesPeriodo.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMesPeriodo.Location = new System.Drawing.Point(166, 164);
            this.cmbMesPeriodo.Name = "cmbMesPeriodo";
            this.cmbMesPeriodo.Size = new System.Drawing.Size(121, 21);
            this.cmbMesPeriodo.TabIndex = 31;
            this.cmbMesPeriodo.SelectedIndexChanged += new System.EventHandler(this.cmbMesPeriodo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(291, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Año:";
            // 
            // cmbAñoPeriodo
            // 
            this.cmbAñoPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAñoPeriodo.FormattingEnabled = true;
            this.cmbAñoPeriodo.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027"});
            this.cmbAñoPeriodo.Location = new System.Drawing.Point(329, 163);
            this.cmbAñoPeriodo.Name = "cmbAñoPeriodo";
            this.cmbAñoPeriodo.Size = new System.Drawing.Size(77, 21);
            this.cmbAñoPeriodo.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(14, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tipo:";
            // 
            // rbnComision
            // 
            this.rbnComision.AutoSize = true;
            this.rbnComision.Location = new System.Drawing.Point(166, 208);
            this.rbnComision.Name = "rbnComision";
            this.rbnComision.Size = new System.Drawing.Size(67, 17);
            this.rbnComision.TabIndex = 35;
            this.rbnComision.TabStop = true;
            this.rbnComision.Text = "Comision";
            this.rbnComision.UseVisualStyleBackColor = true;
            // 
            // rbnBono
            // 
            this.rbnBono.AutoSize = true;
            this.rbnBono.Location = new System.Drawing.Point(256, 208);
            this.rbnBono.Name = "rbnBono";
            this.rbnBono.Size = new System.Drawing.Size(50, 17);
            this.rbnBono.TabIndex = 36;
            this.rbnBono.TabStop = true;
            this.rbnBono.Text = "Bono";
            this.rbnBono.UseVisualStyleBackColor = true;
            // 
            // rbnPenalidad
            // 
            this.rbnPenalidad.AutoSize = true;
            this.rbnPenalidad.Location = new System.Drawing.Point(332, 208);
            this.rbnPenalidad.Name = "rbnPenalidad";
            this.rbnPenalidad.Size = new System.Drawing.Size(72, 17);
            this.rbnPenalidad.TabIndex = 37;
            this.rbnPenalidad.TabStop = true;
            this.rbnPenalidad.Text = "Penalidad";
            this.rbnPenalidad.UseVisualStyleBackColor = true;
            // 
            // FrmGestionarComboProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 260);
            this.Controls.Add(this.rbnPenalidad);
            this.Controls.Add(this.rbnBono);
            this.Controls.Add(this.rbnComision);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAñoPeriodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMesPeriodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.cmbCombo);
            this.Controls.Add(this.cmbCanal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tsMenu);
            this.Name = "FrmGestionarComboProducto";
            this.Text = "Gestionar Combo Productos";
            this.Load += new System.EventHandler(this.GestionarProductos_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private ComboBox cmbProducto;
        private ComboBox cmbCombo;
        private ComboBox cmbCanal;
        private Label label7;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox cmbMesPeriodo;
        private Label label4;
        private ComboBox cmbAñoPeriodo;
        private Label label6;
        private RadioButton rbnComision;
        private RadioButton rbnBono;
        private RadioButton rbnPenalidad;
        private ToolStripButton btnImportar;
    }
}