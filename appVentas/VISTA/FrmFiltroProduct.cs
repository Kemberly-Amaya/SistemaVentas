using appVentas.DAO;
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
    public partial class FrmFiltroProduct : Form
    {
        public FrmFiltroProduct()
        {
            InitializeComponent();
        }
        //método para cargar
        void CargarDatos() {
            //inherencia de datos
            var clsDProducto = new ClsDProducto();
            //Limpiar dtg 
            dtgFiltroDato.Rows.Clear();

            //Mediante foreach se le van a cargar los datos al dtg 
            //Se le envia el argumento de la caja de texto
            foreach (var listarDatos in clsDProducto.CargarProductoFiltro(txtNombreFiltro.Text)) {
                dtgFiltroDato.Rows.Add(listarDatos.idProducto,listarDatos.nombreProducto, listarDatos.precioProducto);
            
            }
        
        }
        private void FrmFiltroProduct_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtNombreFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dtgFiltroDato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
  
        }
        void Enviar() {
            //Crear variables
            // mediante el click seleccionar datos en la fila  y enviarlo al ormulario de venta
            //Esto es un arreglo
            String id = dtgFiltroDato.CurrentRow.Cells[0].Value.ToString();
            String nombre = dtgFiltroDato.CurrentRow.Cells[1].Value.ToString();
            String precio = dtgFiltroDato.CurrentRow.Cells[2].Value.ToString();

            ////Enviar los datos 
            // Esto opcional cuandose quiere abrir otro objeto
            //FrmVenta frmVenta = new FrmVenta();
            //frmVenta.txtCodigoProducto.Text = id;
            //frmVenta.txtNombreProducto.Text = nombre;
            //frmVenta.txtPrecio.Text = precio;
            //frmVenta.Show();
            //this.Close(); //Cierra el formulario y lo borra de memoria

            //Abrir formulario con la variable global creada en el Menu
            //Enviar los datos a los textbox en Venta
            //Herencia de Objetos
            FrmMenu.frmVenta.txtCodigoProducto.Text = id;
            FrmMenu.frmVenta.txtNombreProducto.Text = nombre;
            FrmMenu.frmVenta.txtPrecio.Text = precio;
            //Para que el usuario final no teng que realizar la accion de usar el mouse
            FrmMenu.frmVenta.txtCantidad.Focus();


            this.Close();
        }

        private void dtgFiltroDato_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Enviar();
        }

       

        private void dtgFiltroDato_KeyDown(object sender, KeyEventArgs e)
        {
            //Se detectara a traves de una desición
            //e --- hace referencia a evento
            //Keys --- teclas
            if (e.KeyCode == Keys.Enter)
            {
                Enviar();
            }
        }

        private void dtgFiltroDato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
