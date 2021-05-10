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
        public List<tb_cliente> CargarDatosTbClientes()
        {
            List<tb_cliente> Lista;

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                Lista = db.tb_cliente.ToList();
            }

            return Lista;
        }
        public void InsertarCliente(tb_cliente cliente) {
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

                    MessageBox.Show("Dato Agregado");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }

        }
        public void ActualizarCliente(tb_cliente cliente1) {
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

                    MessageBox.Show("Cliente Actualizado");

                }
            }
            catch (Exception ex) {
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
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            
            }
        
        }
    }

}
