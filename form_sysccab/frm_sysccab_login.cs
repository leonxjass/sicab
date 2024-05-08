using form_sysccab;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_sysccab_menu
{
    public partial class frm_sysccab_login : Form
    {
        public frm_sysccab_login()
        {
            InitializeComponent();
        }


        SqlConnection conexion = new SqlConnection("Data Source=ITDAJL03;Initial Catalog=prueba;User ID=anderson.leon;Integrated Security=true");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Select * From usuarios where nombre_usuario='" + txtUsuario.Text + "'and contraseña = '" + txtContrasena.Text + "'", conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Bienvenido " + reader.GetValue(1) + " " + reader.GetValue(3));
                }
                else
                {
                    MessageBox.Show("Usuario no valido");
                }
                reader.Close();

                this.Hide();

                // Mostrar Form2
                main_form formularioMenu = new main_form();


                // Cerrar la aplicación si se cierra Form2
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_sysccab_login_Load(object sender, EventArgs e)
        {
            try
            {

                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
