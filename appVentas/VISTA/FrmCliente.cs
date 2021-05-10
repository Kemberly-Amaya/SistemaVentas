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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            
        }
        void Carga()
        {
            try
            {
                dtgCliente.Rows.Clear();
                ClsDCliente dCliente = new ClsDCliente();
                List<tb_cliente> Lista = dCliente.CargarDatosTbClientes();
                foreach (var iteracion in Lista)
                {
                    dtgCliente.Rows.Add(iteracion.iDCliente, iteracion.nombreCliente, iteracion.direccionCliente, iteracion.duiCliente);

                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            
            }

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

            Carga();   

         }

      

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsDCliente cls = new ClsDCliente();
                tb_cliente tb = new tb_cliente();
                tb.nombreCliente = txtNombreCliente.Text;
                tb.direccionCliente = txtDireccionCliente.Text;
                tb.duiCliente = txtDuiCliente.Text;

                cls.InsertarCliente(tb);
                Carga();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            
            
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsDCliente dCliente = new ClsDCliente();
                tb_cliente tb1 = new tb_cliente();
                tb1.iDCliente = Convert.ToInt32(txtIdCliente.Text);
                tb1.nombreCliente = txtNombreCliente.Text;
                tb1.direccionCliente = txtDireccionCliente.Text;
                tb1.duiCliente = txtDuiCliente.Text;

                dCliente.ActualizarCliente(tb1);
                Carga();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try {
            ClsDCliente clsD = new ClsDCliente();
         
            clsD.EliminarCliente(Convert.ToInt32(txtIdCliente.Text));
            Carga();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void dtgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String Id = dtgCliente.CurrentRow.Cells[0].Value.ToString();
                String NombreCliente = dtgCliente.CurrentRow.Cells[1].Value.ToString();
                String DireccionCliente = dtgCliente.CurrentRow.Cells[2].Value.ToString();
                String DuiCliente = dtgCliente.CurrentRow.Cells[3].Value.ToString();


                txtIdCliente.Text = Id;
                txtNombreCliente.Text = NombreCliente;
                txtDireccionCliente.Text = DireccionCliente;
                txtDuiCliente.Text = DuiCliente;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
