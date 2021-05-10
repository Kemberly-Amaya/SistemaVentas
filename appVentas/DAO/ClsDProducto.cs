using appVentas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appVentas.DAO
{
    class ClsDProducto
    {
        public List<tb_producto> CargarTbProductos()
        { 
                List<tb_producto> Lista;

                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    Lista = db.tb_producto.ToList();
                }

                return Lista;
        }
        
        public void AgregarProducto(tb_producto Tb) {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    tb_producto tb = new tb_producto();

                    tb.nombreProducto = Tb.nombreProducto;
                    tb.precioProducto = Tb.precioProducto;
                    tb.estadoProducto = Tb.estadoProducto;
                    db.tb_producto.Add(tb);
                    db.SaveChanges();

                    MessageBox.Show("Producto agregado");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            
            }

        }

        public void ActualizarProducto(tb_producto producto)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int actualizar = producto.idProducto;
                    tb_producto tbP = new tb_producto();
                    tbP = db.tb_producto.Find(actualizar);
                    tbP.nombreProducto = producto.nombreProducto;
                    tbP.precioProducto = producto.precioProducto;
                    tbP.estadoProducto = producto.estadoProducto;
                    db.SaveChanges();

                    MessageBox.Show("Producto actualizado");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        public void EliminarProducto(int Id)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    tb_producto tb_Producto = new tb_producto();

                    int Eliminar = Convert.ToInt32(Id);
                    tb_Producto = db.tb_producto.Find(Eliminar);
                    db.tb_producto.Remove(tb_Producto);
                    db.SaveChanges();

                    MessageBox.Show("Producto Eliminado");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
    }
}
