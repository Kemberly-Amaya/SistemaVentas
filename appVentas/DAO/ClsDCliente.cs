using appVentas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appVentas.DAO
{
    class ClsDCliente
    {
        ////metodo tipo list tipo tabla cliente contiene las propiedades necesarias para describir la db
        //public List<tb_cliente> CargarComboCliente()
        //{
        //    List<tb_cliente> tb = new List<tb_cliente>();
        //    using (sistema_ventasEntities db = new sistema_ventasEntities())
        //    {
        //        tb = db.tb_cliente.ToList();


        //    }

        //        return tb;
        //}


        //Método para cargar los datos en el data grid y el combobox
        //indica el tipo de dato que devolvera el mètodo
        //Se esta creando la variable
        public List<tb_cliente> CargarDatosTbClientes()
        {
            //al traer los registros y meterlos en una lista se vuelven objetos
            //cada uno de los registros pasan a ser objetos de una lista
            List<tb_cliente> Lista = new List<tb_cliente>();

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                Lista = db.tb_cliente.ToList();
            }

            return Lista;
        }




        public void InsertarCliente(tb_cliente cliente)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    tb_cliente tb_Cliente = new tb_cliente();

                    tb_Cliente.nombreCliente = cliente.nombreCliente;
                    tb_Cliente.direccionCliente = cliente.direccionCliente;
                    tb_Cliente.duiCliente = cliente.duiCliente;
                    db.tb_cliente.Add(tb_Cliente);
                    db.SaveChanges();

                    MessageBox.Show("Exelente" + "\nSe agregó un nuevo registro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void ActualizarCliente(tb_cliente cliente1)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int actualizar = cliente1.iDCliente;
                    tb_cliente tb = new tb_cliente();
                    tb = db.tb_cliente.Find(actualizar);
                    tb.nombreCliente = cliente1.nombreCliente;
                    tb.direccionCliente = cliente1.direccionCliente;
                    tb.duiCliente = cliente1.duiCliente;
                    db.SaveChanges();

                    MessageBox.Show("Exelente" + "\nEl registro se actualizó correctamente");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
        public void EliminarCliente(int Id)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    tb_cliente Tb = new tb_cliente();

                    int Eliminar = Convert.ToInt32(Id);
                    Tb = db.tb_cliente.Find(Eliminar);
                    db.tb_cliente.Remove(Tb);
                    db.SaveChanges();

                    MessageBox.Show("Cliente Eliminado");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

    }

}
