
namespace appVentas.VISTA
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iRUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iRPRODUCTOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.documentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Beige;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.uSUARIOToolStripMenuItem,
            this.pRODUCTOToolStripMenuItem1,
            this.documentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(937, 47);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.irVentaToolStripMenuItem});
            this.ventaToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(97, 39);
            this.ventaToolStripMenuItem.Text = "Venta";
            // 
            // irVentaToolStripMenuItem
            // 
            this.irVentaToolStripMenuItem.Name = "irVentaToolStripMenuItem";
            this.irVentaToolStripMenuItem.Size = new System.Drawing.Size(270, 44);
            this.irVentaToolStripMenuItem.Text = "Ir Venta";
            this.irVentaToolStripMenuItem.Click += new System.EventHandler(this.irVentaToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.irClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(110, 39);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // irClienteToolStripMenuItem
            // 
            this.irClienteToolStripMenuItem.Name = "irClienteToolStripMenuItem";
            this.irClienteToolStripMenuItem.Size = new System.Drawing.Size(270, 44);
            this.irClienteToolStripMenuItem.Text = "Ir cliente";
            this.irClienteToolStripMenuItem.Click += new System.EventHandler(this.irClienteToolStripMenuItem_Click);
            // 
            // uSUARIOToolStripMenuItem
            // 
            this.uSUARIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iRUSUARIOToolStripMenuItem});
            this.uSUARIOToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uSUARIOToolStripMenuItem.Name = "uSUARIOToolStripMenuItem";
            this.uSUARIOToolStripMenuItem.Size = new System.Drawing.Size(118, 39);
            this.uSUARIOToolStripMenuItem.Text = "Usuario";
            // 
            // iRUSUARIOToolStripMenuItem
            // 
            this.iRUSUARIOToolStripMenuItem.Name = "iRUSUARIOToolStripMenuItem";
            this.iRUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(270, 44);
            this.iRUSUARIOToolStripMenuItem.Text = "Ir Usuario";
            this.iRUSUARIOToolStripMenuItem.Click += new System.EventHandler(this.iRUSUARIOToolStripMenuItem_Click);
            // 
            // pRODUCTOToolStripMenuItem1
            // 
            this.pRODUCTOToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iRPRODUCTOToolStripMenuItem1});
            this.pRODUCTOToolStripMenuItem1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pRODUCTOToolStripMenuItem1.Name = "pRODUCTOToolStripMenuItem1";
            this.pRODUCTOToolStripMenuItem1.Size = new System.Drawing.Size(131, 39);
            this.pRODUCTOToolStripMenuItem1.Text = "Producto";
            this.pRODUCTOToolStripMenuItem1.Click += new System.EventHandler(this.pRODUCTOToolStripMenuItem1_Click);
            // 
            // iRPRODUCTOToolStripMenuItem1
            // 
            this.iRPRODUCTOToolStripMenuItem1.Name = "iRPRODUCTOToolStripMenuItem1";
            this.iRPRODUCTOToolStripMenuItem1.Size = new System.Drawing.Size(270, 44);
            this.iRPRODUCTOToolStripMenuItem1.Text = "Ir Producto";
            this.iRPRODUCTOToolStripMenuItem1.Click += new System.EventHandler(this.iRPRODUCTOToolStripMenuItem1_Click);
            // 
            // documentoToolStripMenuItem
            // 
            this.documentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.irDocumentoToolStripMenuItem});
            this.documentoToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentoToolStripMenuItem.Name = "documentoToolStripMenuItem";
            this.documentoToolStripMenuItem.Size = new System.Drawing.Size(154, 39);
            this.documentoToolStripMenuItem.Text = "Documento";
            // 
            // irDocumentoToolStripMenuItem
            // 
            this.irDocumentoToolStripMenuItem.Name = "irDocumentoToolStripMenuItem";
            this.irDocumentoToolStripMenuItem.Size = new System.Drawing.Size(278, 44);
            this.irDocumentoToolStripMenuItem.Text = "Ir Documento";
            this.irDocumentoToolStripMenuItem.Click += new System.EventHandler(this.irDocumentoToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(937, 870);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iRUSUARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iRPRODUCTOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem documentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irDocumentoToolStripMenuItem;
    }
}