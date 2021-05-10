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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }
        void Limpiar()
        {
            txtIdProducto.Clear();
            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();
            txtEstadoProducto.Clear();
            
        }
        void Carga()
        {
            try
            {
                dtgProductos.Rows.Clear();
                ClsDProducto dProducto = new ClsDProducto();
                List<tb_producto> Lista = dProducto.CargarTbProductos();
                foreach (var iteracion in Lista)
                {
                    dtgProductos.Rows.Add(iteracion.idProducto, iteracion.nombreProducto, iteracion.precioProducto, iteracion.estadoProducto);

                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString());
            
            }
        }
        private void FrmProducto_Load(object sender, EventArgs e)
        {
            Carga();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try {
                ClsDProducto cls = new ClsDProducto();
                tb_producto producto = new tb_producto();

                producto.nombreProducto = txtNombreProducto.Text;
                producto.precioProducto = txtPrecioProducto.Text;
                producto.estadoProducto = txtEstadoProducto.Text;

                cls.AgregarProducto(producto);
                Carga();
                Limpiar();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
             
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ClsDProducto clsDP = new ClsDProducto();
                tb_producto Producto = new tb_producto();

                Producto.idProducto = Convert.ToInt32(txtIdProducto.Text);
                Producto.nombreProducto = txtNombreProducto.Text;
                Producto.precioProducto = txtPrecioProducto.Text;
                Producto.estadoProducto = txtEstadoProducto.Text;


                clsDP.ActualizarProducto(Producto);
                Carga();
                Limpiar();
             
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String Id = dtgProductos.CurrentRow.Cells[0].Value.ToString();
                String NombreProducto = dtgProductos.CurrentRow.Cells[1].Value.ToString();
                String PrecioProducto = dtgProductos.CurrentRow.Cells[2].Value.ToString();
                String EstadoProducto = dtgProductos.CurrentRow.Cells[3].Value.ToString();



                txtIdProducto.Text = Id;
                txtNombreProducto.Text = NombreProducto;
                txtPrecioProducto.Text = PrecioProducto;
                txtEstadoProducto.Text = EstadoProducto;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsDProducto cls = new ClsDProducto();
       
                
                cls.EliminarProducto(Convert.ToInt32(txtIdProducto.Text));
                Carga();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void dtgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
