using appVentas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appVentas.DAO
{
    class ClsDVenta
    {
        //Consulta que devuelve ellistado de las ventas
        public List<tb_venta> UltimaVenta() {

            List<tb_venta> ConsultarUltimaVenta = new List<tb_venta>();

            using (sistema_ventasEntities db = new sistema_ventasEntities()) {
                ConsultarUltimaVenta = db.tb_venta.ToList();
            
            }
            //retornamos consulta
                return ConsultarUltimaVenta;
        }
        //enviar datos a la tabla de venta
       public void save(tb_venta ventas){
            using (sistema_ventasEntities db = new sistema_ventasEntities()) 
            {
                //comparacion de datos para traer los parametros 
                //tabla encargada de almacenar todos los registros en la base de datos
                var venta = new tb_venta();

                venta.iDDocumento = ventas.iDDocumento;
                venta.iDCliente = ventas.iDCliente;
                venta.iDUsuario = ventas.iDUsuario;
                venta.iDProducto = ventas.iDProducto;
                venta.totalVenta = ventas.totalVenta;
                venta.fecha = ventas.fecha;
                db.tb_venta.Add(venta);
                db.SaveChanges();

            }
        }  
    }
    
}
