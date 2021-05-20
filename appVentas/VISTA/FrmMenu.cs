using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appVentas.VISTA
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        //abrir como formulario externo
        //Es estático porque cuando se  busque un producto se va necesitar acceder a una sola instancia es decir a una variable
        // publica porque queremos acceder a ella
        //estatica porque no se quiere modificar su valor
        public static FrmVenta frmVenta = new FrmVenta();

        private void irVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenta.Show();

        }

        private void irClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmC = new FrmCliente();
            frmC.MdiParent = this;
            frmC.Show();
        }

        private void iRUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmU = new FrmUsuario();
            frmU.MdiParent = this;
            frmU.Show();
        }

        private void pRODUCTOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void irDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDocumento frmD = new FrmDocumento();
            frmD.MdiParent = this;
            frmD.Show();
        }

        private void iRPRODUCTOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProducto frmP = new FrmProducto();
            frmP.MdiParent = this;
            frmP.Show();
        }
    }
}
