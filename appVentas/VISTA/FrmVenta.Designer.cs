
namespace appVentas.VISTA
{
    partial class FrmVenta
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
            this.txtNumeroDeDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTipoDeDocumento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.dtgFrmVenta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalFinal = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFrmVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumeroDeDocumento
            // 
            this.txtNumeroDeDocumento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNumeroDeDocumento.Enabled = false;
            this.txtNumeroDeDocumento.Location = new System.Drawing.Point(72, 67);
            this.txtNumeroDeDocumento.Name = "txtNumeroDeDocumento";
            this.txtNumeroDeDocumento.Size = new System.Drawing.Size(320, 26);
            this.txtNumeroDeDocumento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id de Ultima venta";
            // 
            // cbxTipoDeDocumento
            // 
            this.cbxTipoDeDocumento.FormattingEnabled = true;
            this.cbxTipoDeDocumento.Location = new System.Drawing.Point(616, 67);
            this.cbxTipoDeDocumento.Name = "cbxTipoDeDocumento";
            this.cbxTipoDeDocumento.Size = new System.Drawing.Size(273, 28);
            this.cbxTipoDeDocumento.TabIndex = 3;
            this.cbxTipoDeDocumento.SelectedIndexChanged += new System.EventHandler(this.cbxTipoDeDocumento_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(578, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(578, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cliente";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(616, 157);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(273, 28);
            this.cbxCliente.TabIndex = 6;
            this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.cbxCliente_SelectedIndexChanged);
            // 
            // dtgFrmVenta
            // 
            this.dtgFrmVenta.AllowUserToAddRows = false;
            this.dtgFrmVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgFrmVenta.BackgroundColor = System.Drawing.Color.Plum;
            this.dtgFrmVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFrmVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgFrmVenta.Location = new System.Drawing.Point(16, 320);
            this.dtgFrmVenta.Name = "dtgFrmVenta";
            this.dtgFrmVenta.ReadOnly = true;
            this.dtgFrmVenta.RowHeadersWidth = 62;
            this.dtgFrmVenta.RowTemplate.Height = 28;
            this.dtgFrmVenta.Size = new System.Drawing.Size(970, 233);
            this.dtgFrmVenta.TabIndex = 7;
            this.dtgFrmVenta.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgFrmVenta_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código de Producto";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre de Producto";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio de Producto";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad de Producto";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(75, 156);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(319, 26);
            this.txtBuscarProducto.TabIndex = 8;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarProducto_TextChanged);
            this.txtBuscarProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarProducto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Buscar Producto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnBuscar.Location = new System.Drawing.Point(415, 153);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 32);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Enabled = false;
            this.txtCodigoProducto.Location = new System.Drawing.Point(33, 265);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(198, 26);
            this.txtCodigoProducto.TabIndex = 11;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Enabled = false;
            this.txtNombreProducto.Location = new System.Drawing.Point(251, 265);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(221, 26);
            this.txtNombreProducto.TabIndex = 12;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(491, 265);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(176, 26);
            this.txtPrecio.TabIndex = 13;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(688, 265);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(163, 26);
            this.txtCantidad.TabIndex = 14;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(37, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Código Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(247, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nombre Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(499, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(695, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cantidad";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(869, 265);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(171, 26);
            this.txtTotal.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(877, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(1006, 487);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Total Final";
            // 
            // txtTotalFinal
            // 
            this.txtTotalFinal.Location = new System.Drawing.Point(1009, 523);
            this.txtTotalFinal.Name = "txtTotalFinal";
            this.txtTotalFinal.Size = new System.Drawing.Size(130, 26);
            this.txtTotalFinal.TabIndex = 23;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAgregar.Location = new System.Drawing.Point(1010, 320);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(142, 46);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(952, 70);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 26);
            this.dtpFecha.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(952, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Fecha :";
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarVenta.Location = new System.Drawing.Point(1010, 387);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(137, 40);
            this.btnAgregarVenta.TabIndex = 27;
            this.btnAgregarVenta.Text = "Agregar Venta";
            this.btnAgregarVenta.UseVisualStyleBackColor = false;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // FrmVenta
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::appVentas.Properties.Resources.tecnologiaDigital;
            this.ClientSize = new System.Drawing.Size(1159, 574);
            this.Controls.Add(this.btnAgregarVenta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtTotalFinal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.dtgFrmVenta);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxTipoDeDocumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroDeDocumento);
            this.Name = "FrmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVenta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFrmVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroDeDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTipoDeDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.DataGridView dtgFrmVenta;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.TextBox txtCodigoProducto;
        public System.Windows.Forms.TextBox txtNombreProducto;
        public System.Windows.Forms.TextBox txtPrecio;
        public System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalFinal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAgregarVenta;
    }
}