
namespace appVentas.VISTA
{
    partial class FrmFiltroProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreFiltro = new System.Windows.Forms.TextBox();
            this.dtgFiltroDato = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFiltroDato)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombreFiltro
            // 
            this.txtNombreFiltro.Location = new System.Drawing.Point(146, 86);
            this.txtNombreFiltro.Name = "txtNombreFiltro";
            this.txtNombreFiltro.Size = new System.Drawing.Size(691, 33);
            this.txtNombreFiltro.TabIndex = 1;
            this.txtNombreFiltro.TextChanged += new System.EventHandler(this.txtNombreFiltro_TextChanged);
            // 
            // dtgFiltroDato
            // 
            this.dtgFiltroDato.AllowUserToAddRows = false;
            this.dtgFiltroDato.AllowUserToDeleteRows = false;
            this.dtgFiltroDato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgFiltroDato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFiltroDato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgFiltroDato.Location = new System.Drawing.Point(33, 147);
            this.dtgFiltroDato.Name = "dtgFiltroDato";
            this.dtgFiltroDato.ReadOnly = true;
            this.dtgFiltroDato.RowHeadersWidth = 62;
            this.dtgFiltroDato.RowTemplate.Height = 28;
            this.dtgFiltroDato.Size = new System.Drawing.Size(889, 352);
            this.dtgFiltroDato.TabIndex = 2;
            this.dtgFiltroDato.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFiltroDato_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 42.61361F;
            this.Column1.HeaderText = "Id Producto";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 128.6931F;
            this.Column2.HeaderText = "Nombre Producto";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 128.6931F;
            this.Column3.HeaderText = "Precio Producto";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FrmFiltroProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 540);
            this.Controls.Add(this.dtgFiltroDato);
            this.Controls.Add(this.txtNombreFiltro);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmFiltroProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFiltroProduct";
            this.Load += new System.EventHandler(this.FrmFiltroProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFiltroDato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreFiltro;
        private System.Windows.Forms.DataGridView dtgFiltroDato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}