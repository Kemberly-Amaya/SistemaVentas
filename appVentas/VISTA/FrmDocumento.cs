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
    public partial class FrmDocumento : Form
    {
        public FrmDocumento()
        {
            InitializeComponent();
        }
        void Limpiar()
        {
            txtIdDocumento.Clear();
            txtNombreDocumento.Clear();
         
        }
        void Cargar()
        {
            try
            {
                dtgDocumento.Rows.Clear();
                ClsDdocumento documento = new ClsDdocumento();
                List<tb_documento> Lista = documento.CargarTbDocumento();
                foreach (var iteracion in Lista)
                {
                    dtgDocumento.Rows.Add(iteracion.iDDocumento, iteracion.nombreDocumento);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void FrmDocumento_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try {
                ClsDdocumento clsDdocumento = new ClsDdocumento();
                tb_documento tb = new tb_documento();
                tb.nombreDocumento = txtNombreDocumento.Text;

                clsDdocumento.InsertarDocumento(tb);
                Cargar();
                Limpiar();
            
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
 
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try {
                ClsDdocumento clsdocumento = new ClsDdocumento();
                tb_documento Tb = new tb_documento();
                Tb.iDDocumento = Convert.ToInt32(txtIdDocumento.Text);
                Tb.nombreDocumento = txtNombreDocumento.Text;

                clsdocumento.ActualizarDocumento(Tb);
                Cargar();
                Limpiar();
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsDdocumento clsdocument = new ClsDdocumento();
                tb_documento Tab = new tb_documento();
                clsdocument.EliminarDocumento(Convert.ToInt32(txtIdDocumento.Text));
                Cargar();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void dtgDocumento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgDocumento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String Id = dtgDocumento.CurrentRow.Cells[0].Value.ToString();
                String NombreDocumento = dtgDocumento.CurrentRow.Cells[1].Value.ToString();




                txtIdDocumento.Text = Id;
                txtNombreDocumento.Text = NombreDocumento;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
