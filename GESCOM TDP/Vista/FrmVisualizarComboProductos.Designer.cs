namespace Vista
{
    partial class FrmVisualizarComboProductos
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
            this.dgvComboProducto = new System.Windows.Forms.DataGridView();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCanal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComboProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComboProducto
            // 
            this.dgvComboProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComboProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProducto,
            this.NombreCanal,
            this.NombreCombo});
            this.dgvComboProducto.Location = new System.Drawing.Point(12, 107);
            this.dgvComboProducto.Name = "dgvComboProducto";
            this.dgvComboProducto.Size = new System.Drawing.Size(750, 219);
            this.dgvComboProducto.TabIndex = 0;
            this.dgvComboProducto.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvComboProducto_ColumnHeaderMouseClick);
            // 
            // NombreProducto
            // 
            this.NombreProducto.DataPropertyName = "NombreProducto";
            this.NombreProducto.FillWeight = 250F;
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.NombreProducto.Width = 200;
            // 
            // NombreCanal
            // 
            this.NombreCanal.DataPropertyName = "NombreCanal";
            this.NombreCanal.FillWeight = 250F;
            this.NombreCanal.HeaderText = "Nombre Canal";
            this.NombreCanal.Name = "NombreCanal";
            this.NombreCanal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.NombreCanal.Width = 250;
            // 
            // NombreCombo
            // 
            this.NombreCombo.DataPropertyName = "NombreCombo";
            this.NombreCombo.FillWeight = 250F;
            this.NombreCombo.HeaderText = "Nombre Combo";
            this.NombreCombo.Name = "NombreCombo";
            this.NombreCombo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.NombreCombo.Width = 250;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(657, 11);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // cbCampo
            // 
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Items.AddRange(new object[] {
            "Canal",
            "Combo"});
            this.cbCampo.Location = new System.Drawing.Point(64, 50);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(121, 21);
            this.cbCampo.TabIndex = 3;
            // 
            // FrmVisualizarComboProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCampo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvComboProducto);
            this.Name = "FrmVisualizarComboProductos";
            this.Text = "FrmVisualizarComboProductos";
            this.Load += new System.EventHandler(this.FrmVisualizarComboProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComboProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComboProducto;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCanal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCombo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbCampo;
    }
}