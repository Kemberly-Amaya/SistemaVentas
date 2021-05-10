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
            using (sistema_ventasEntities bd= new sistema_ventasEntities())
            {
                var consultacliente = bd.tb_documento.ToList();

                cbxCliente.DataSource = consultacliente; //
                cbxCliente.DisplayMember = "nombreCliente"; // Mostrara miembros de la db
                cbxCliente.ValueMember = "iDCliente"; //

                //var consultadocumento = (from documento in bd.tb_documento
                //                        select new { 

                //                        documento.iDDocumento,
                //                        documento.nombreDocumento

                //                        });.ToList();


                var consultadocumento = bd.tb_documento.ToList();
                cbxTipoDeDocumento.DataSource = consultadocumento;
                cbxTipoDeDocumento.DisplayMember = "nombreDocumento";
                cbxTipoDeDocumento.ValueMember = "iDDocumento";


            }
        }
    }
}
