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
        //Se trae el id de ultima venta
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
            //DataSource sirve para establecer el origen de datos -- o obtener el origen de datos sirve para decir de donde se van a obtener los datos mostrados en el combobox
            // datasource ... parecido a un data set pero es propio de un elemento ---
            cbxCliente.DataSource = clsDCliente.CargarDatosTbClientes();
            cbxCliente.DisplayMember = "nombreCliente"; // Mostrara miembros de la db es el elemento  que se va mostrar
                                                        //Selecciona el valor que se mostrara en el combo box y lo toma del datasource
            cbxCliente.ValueMember = "iDCliente"; //ruta de accceso es decir un id para los elementos o items y el identificador para cada items sera el id

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
        {
            calcular();
        }
        void calcular() {
            try
            {
                //propiedad que ayudara a validar que aunque la caja este vacia le coloque un texto que será cero
                //try catch -- funcionara como if, el if hirá en el catch
                //Función del cálculo
                Double precio, cantidad, total;

                cantidad = Convert.ToDouble(txtCantidad.Text);
                precio = Convert.ToDouble(txtPrecio.Text);
                total = precio * cantidad;

                // mostrar en la caja de texto
                txtTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                if (txtCantidad.Text.Equals(""))
                {
                    txtCantidad.Text = "1";
                    //selccionar ese cero y cuando el usuario presione otro numero lo replace por el numero selecionado
                    txtCantidad.SelectAll();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            calculartotal();
            
        }
            void calculartotal()
            {
          
            //Se le agregaran los datos al datagrid
            dtgFrmVenta.Rows.Add(txtCodigoProducto.Text, txtNombreProducto.Text, txtPrecio.Text, txtCantidad.Text, txtTotal.Text);

            //for ayudara a realizar una suma automatica de la columna Total
            //realizar suma automatica
            Double suma = 0;
            for (int i = 0; i < dtgFrmVenta.Rows.Count; i++)
            { //esta linea solo cuenta los datos del dtg

                ////String precio = dtgFrmVenta.CurrentRow.Cells[2].Value.ToString();
                ////contara todas las filas y que trabaje con la columna 4
                String datosaOperartotal = dtgFrmVenta.Rows[i].Cells[4].Value.ToString();


                Double DatosConvertidos = Convert.ToDouble(datosaOperartotal);
                suma += DatosConvertidos;

                txtTotalFinal.Text = suma.ToString();
                // otra forma de hacerlo
                // suma += DatosConvertidos;

                // += --es un dato acumulativo, e sobre escribir lo datos en una misma variable
                //suma = suma + DatosConvertidos;
                calcular();
                txtCodigoProducto.Clear();
                txtNombreProducto.Clear();
                txtPrecio.Clear();
                txtCantidad.Clear();
                txtTotal.Clear();

            }
           
            //Manipular el scrolling
            //uso del método Refresh--actualizar los datos sin eliminarlos, es decir haga saltos por dentro de forma automatica
            //llegar hasta a ultima fila
            dtgFrmVenta.Refresh();
            //tabien necesitamos que el dtg borre la selección y coloque en la ultima posición 
            dtgFrmVenta.ClearSelection();
            // int -- entero porque las filas se manejan con datos enteros 
            //todo lo que agrege el dtg menos 1
            int ultimafila = dtgFrmVenta.Rows.Count - 1;
            //metodo que colocará la posicion en la primera fila que aparezca en el dtg
            dtgFrmVenta.FirstDisplayedScrollingRowIndex = ultimafila;
            //Activamos metodo Handled = true 
            dtgFrmVenta.Rows[ultimafila].Selected = true;
            //agregar el metodo de selcion y pasar la ultima fila
            }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==13)
            {
                e.Handled = true;
                btnAgregar.PerformClick();
                txtBuscarProducto.Focus();
            }
        }
        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==13)

            if (txtBuscarProducto.Text.Equals(""))
                {
                    //e.Handled = true;
                    btnAgregar.PerformClick();
                    txtCantidad.Focus();
                }
            else
            {
                {
                    e.Handled = true;
                    ClsDProducto prod = new ClsDProducto();
                    //pasamos el argumento
                    var busqueda = prod.BuscarProducto(Convert.ToInt32(txtBuscarProducto.Text));

                        if (busqueda.Count<1) {
                            MessageBox.Show("Lo siento" + "\n No he encontrado coincidencias");
                            txtBuscarProducto.Clear();
                        }
                    foreach (var iterar in busqueda)
                    {
                        txtCodigoProducto.Text = iterar.idProducto.ToString();
                        txtNombreProducto.Text = iterar.nombreProducto;
                        txtPrecio.Text = iterar.precioProducto.ToString();
                        txtCantidad.Text = "1";
                        txtCantidad.Focus();
                        txtBuscarProducto.Text = "";
                    }
                }
            }
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                var Clsventa = new ClsDVenta();
                var venta = new tb_venta();

                venta.iDDocumento = Convert.ToInt32(cbxTipoDeDocumento.SelectedValue.ToString());
                venta.iDCliente = Convert.ToInt32(cbxCliente.SelectedValue.ToString());
                venta.iDProducto = 1;
                venta.iDUsuario = 1;
                venta.totalVenta = Convert.ToDecimal(txtTotalFinal.Text);
                //Capturar Fecha
                venta.fecha = Convert.ToDateTime(dtpFecha.Text);
                Clsventa.save(venta);

                var clsDetalle = new ClsDDetalle();
                var tbdetalleVenta = new tb_detalleVenta();

                foreach (DataGridViewRow dtgv in dtgFrmVenta.Rows) {
                    for (int i = 0; i < dtgFrmVenta.Rows.Count; i++) {

                        tbdetalleVenta.idVenta = Convert.ToInt32(txtNumeroDeDocumento.Text);
                        tbdetalleVenta.idProducto = Convert.ToInt32(dtgv.Cells[0].Value.ToString());
                        tbdetalleVenta.cantidad = Convert.ToInt32(dtgv.Cells[3].Value.ToString());
                        tbdetalleVenta.precio = Convert.ToDecimal(dtgv.Cells[2].Value.ToString());
                        tbdetalleVenta.total = Convert.ToDecimal(dtgv.Cells[4].Value.ToString());
                        clsDetalle.guardardetalleventa(tbdetalleVenta);
                    }
                    ultimocorrelativodeventa();
                    dtgFrmVenta.Rows.Clear();
                    }
                MessageBox.Show("Guardado");
            }
            catch (Exception ex) {
                MessageBox.Show("¡ Error !\n" + ex);
            
            }

        }

        private void dtgFrmVenta_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calculartotal();
        }
    }
}


