using appVentas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appVentas.DAO
{
    class ClsDUsuario
    {
        public List<tb_usuario> CargarTbUsuario()
        {
            List<tb_usuario> Lista;

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                Lista = db.tb_usuario.ToList();
            }

            return Lista;
        }
        public void InsertarUsuario(tb_usuario Usu)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    tb_usuario tb_Usu = new tb_usuario();
                    tb_Usu.email = Usu.email;
                    tb_Usu.contrasena = Usu.contrasena;
                    db.tb_usuario.Add(tb_Usu);
                    db.SaveChanges();

                    MessageBox.Show("Dato Agregado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void ActualizarUsu(tb_usuario Usu1)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int actualizar = Usu1.iDUsuario;
                    tb_usuario usu = new tb_usuario();
                    usu = db.tb_usuario.Find(actualizar);
                    usu.email = Usu1.email;
                    usu.contrasena = Usu1.contrasena;
                    db.SaveChanges();

                    MessageBox.Show("Datos Actualizados");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
        public void EliminarUsuario(int Id)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    tb_usuario tableUsu = new tb_usuario();

                    int Eliminar = Convert.ToInt32(Id);
                    tableUsu = db.tb_usuario.Find(Eliminar);
                    db.tb_usuario.Remove(tableUsu);
                    db.SaveChanges();

                    MessageBox.Show("Datos Eliminados");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

    }
}