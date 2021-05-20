using appVentas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appVentas.DAO
{
    class ClsDdocumento
    {
        public List<tb_documento> CargarTbDocumento()
        {
            List<tb_documento> Lista =new List<tb_documento>();

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                Lista = db.tb_documento.ToList();
            }

            return Lista;
        }
        public void InsertarDocumento(tb_documento Tb)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    tb_documento tb = new tb_documento();

                    tb.nombreDocumento = Tb.nombreDocumento;
                    db.tb_documento.Add(tb);
                    db.SaveChanges();

                    MessageBox.Show("Documento agregado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
        public void ActualizarDocumento(tb_documento tb)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int actualizar = tb.iDDocumento;
                    tb_documento tbd = new tb_documento();
                    tbd = db.tb_documento.Find(actualizar);
                    tbd.nombreDocumento = tb.nombreDocumento;
                    db.SaveChanges();
                    MessageBox.Show("Documento modificado");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        public void EliminarDocumento(int Id)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    tb_documento tB = new tb_documento();

                    int Eliminar = Convert.ToInt32(Id);
                    tB = db.tb_documento.Find(Eliminar);
                    db.tb_documento.Remove(tB);
                    db.SaveChanges();
                    MessageBox.Show("Documento Eliminado");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
        //public List<tb_documento> CargarComboDocumento()
        //{
        //    //Otro metodo para retornar un valor 
        //    List<tb_documento> tb_Documento = new List<tb_documento>();
        //    using (sistema_ventasEntities db = new sistema_ventasEntities())
        //    {
        //        tb_Documento = db.tb_documento.ToList();
        //    }
        //    return tb_Documento;
        //}
    }
}
