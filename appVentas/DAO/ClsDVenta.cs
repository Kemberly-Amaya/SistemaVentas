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
    }
}
