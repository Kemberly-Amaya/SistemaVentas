using appVentas.DAO;
using appVentas.MODEL;
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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
         
            ClsDCliente clsDCliente = new ClsDCliente();

            cbxCliente.DataSource = clsDCliente.CargarDatosTbClientes();
            cbxCliente.DisplayMember = "nombreCliente"; // Mostrara miembros de la db
            cbxCliente.ValueMember = "iDCliente"; //
          


            ClsDdocumento clsDocumento = new ClsDdocumento();

            cbxTipoDeDocumento.DataSource = clsDocumento.CargarTbDocumento();
            cbxTipoDeDocumento.DisplayMember = "nombreDocumento";
            cbxTipoDeDocumento.ValueMember = "iDDocumento";

        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxTipoDeDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Evento para mostrar el form al presionar boton buscar
            FrmFiltroProduct buscar = new FrmFiltroProduct();
            buscar.Show();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
