using form_sysccab;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace form_sysccab_menu
{
    public partial class frm_sysccab_login : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=ITDAJL03;Initial Catalog=prueba;User ID=anderson.leon;Integrated Security=true");

        public frm_sysccab_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getConexion();
        }

        private void getConexion()
        {
            try
            {
                string consulta = "SELECT * FROM usuarios WHERE nombre_usuario = @usuario AND contraseña = @contraseña";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@contraseña", txtContrasena.Text);

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("¡Bienvenido " + reader["nombre"] + " " + reader["apellido"] + "!");

                    // Cerrar la conexión
                    conexion.Close();

                    // Mostrar el formulario del menú
                    frm_sysccab_menu formularioMenu = new frm_sysccab_menu();
                    //formularioMenu.Show();

                    // Ocultar este formulario
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario no válido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        private void frm_sysccab_login_Load(object sender, EventArgs e)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
