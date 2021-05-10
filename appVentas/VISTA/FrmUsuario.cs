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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }
        void Limpiar()
        {
            txtIdUsuario.Clear();
            txtEmail.Clear();
            txtPass.Clear();
          
        }
        void Cargar()
        {
            try
            {
                dtgUsuario.Rows.Clear();
                ClsDUsuario cls = new ClsDUsuario();
                List<tb_usuario> Lista = cls.CargarTbUsuario();
                foreach (var iteracion in Lista)
                {
                    dtgUsuario.Rows.Add(iteracion.iDUsuario, iteracion.email, iteracion.contrasena);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClsDUsuario cls = new ClsDUsuario();
            tb_usuario tbUsu = new tb_usuario();
            tbUsu.email = txtEmail.Text;
            tbUsu.contrasena = txtPass.Text;

            cls.InsertarUsuario(tbUsu);
            Cargar();
            Limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsDUsuario clsD = new ClsDUsuario();
                tb_usuario usuario = new tb_usuario();

                usuario.iDUsuario = Convert.ToInt32(txtIdUsuario.Text);
                usuario.email = txtEmail.Text;
                usuario.contrasena = txtPass.Text;
                clsD.ActualizarUsu(usuario);
                Cargar();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsDUsuario clsD = new ClsDUsuario();
                tb_usuario TabUsu = new tb_usuario();
                clsD.EliminarUsuario(Convert.ToInt32(txtIdUsuario.Text));
                Cargar();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void dtgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dtgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String Id = dtgUsuario.CurrentRow.Cells[0].Value.ToString();
                String Email = dtgUsuario.CurrentRow.Cells[1].Value.ToString();
                String Pass = dtgUsuario.CurrentRow.Cells[2].Value.ToString();



                txtIdUsuario.Text = Id;
                txtEmail.Text = Email;
                txtPass.Text = Pass;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
