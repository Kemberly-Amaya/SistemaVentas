using appVentas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appVentas.DAO
{
    class ClsDDetalle
    {
        public void guardardetalleventa(tb_detalleVenta detalle) {
            using (sistema_ventasEntities db = new sistema_ventasEntities()) 
            {
                var tbDetalleventa = new tb_detalleVenta();
                tbDetalleventa.idVenta = detalle.idVenta;
                tbDetalleventa.idProducto = detalle.idProducto;
                tbDetalleventa.cantidad = detalle.cantidad;
                tbDetalleventa.precio = detalle.precio;
                tbDetalleventa.total = detalle.total;
                db.tb_detalleVenta.Add(tbDetalleventa);
                db.SaveChanges();
            
            
            }
        }
    }
}
