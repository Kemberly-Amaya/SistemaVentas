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
        void ultimocorrelativodeventa()
        {
            //Objeto de tipo ClsVenta
            var ConsultarUltimaVenta = new ClsDVenta();

            int lista = 0;

            foreach (var list in ConsultarUltimaVenta.UltimaVenta())
            {
                lista = list.iDVenta;
            }

            lista++;
            txtNumeroDeDocumento.Text = lista.ToString();
        }
        private void FrmVenta_Load(object sender, EventArgs e)
        {
             
            ultimocorrelativodeventa();

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

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {  //propiedad que ayudara a validar que aunque la caja este vacia le coloque un texto que será cero
            //try catch -- funcionara como if, el if hirá en el catch
            try
            {
                //Función del cálculo
                Double precio, cantidad, total;

                cantidad = Convert.ToDouble(txtCantidad.Text);
                precio = Convert.ToDouble(txtPrecio.Text);
                total = precio * cantidad;

                // mostrar en la caja de texto
                txtTotal.Text = total.ToString();
            }
            catch (Exception ex) { 
                if (txtCantidad.Text.Equals("")) {
                    txtCantidad.Text = "0";
                    //selccionar ese cero y cuano el usuario presione otro numero lo replace por el numero selecionado
                    txtCantidad.SelectAll();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Se le agregaran los datos al datagrid
            dtgFrmVenta.Rows.Add(txtCodigoProducto.Text,txtNombreProducto.Text,txtPrecio.Text,txtCantidad.Text,txtTotal.Text);

            //for ayudara a realizar una suma automatica de la columna Total
            //realizar suma automatica

            Double suma = 0;

            for (int i = 0;i<dtgFrmVenta.Rows.Count;i++) { //esta linea solo cuenta los datos del dtg


                // String precio = dtgFiltroDato.CurrentRow.Cells[2].Value.ToString();
                // contara todas las filas y que trabaje con la columna 4
                // String datosaOperartotal = dtgFrmVenta.Rows[i].Cells[4].Value.ToString();
                String datosOperadostotal = dtgFrmVenta.Rows[i].Cells[4].Value.ToString();

                Double DatosConvertidos = Convert.ToDouble(datosOperadostotal);
                
                suma += DatosConvertidos;

                // otra forma de hacerlo
                // suma += DatosConvertidos;

                // += --es un dato acumulativo, e sobre escribir lo datos en una misma variable
                // suma = suma + DatosConvertidos;
                txtTotalFinal.Text = suma.ToString();

                txtCodigoProducto.Clear();
                txtNombreProducto.Clear();
                txtPrecio.Clear();
                txtCantidad.Clear();
                txtTotal.Clear();
            }
        }
    }
}


