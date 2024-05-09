using form_sysccab;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace form_sysccab_menu
{
    public partial class frm_sysccab_login : Form
    {

        public frm_sysccab_login()
        {
            InitializeComponent();
        }

        /*
         * Instancia de la conexion al SQLSERVER 
         */

        private string conexionString = "Data Source=ITDAJL03;Initial Catalog=prueba;User ID=anderson.leon;Integrated Security=true";

        private bool VerificarCredenciales(string usuario, string contrasena)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    string consulta = "SELECT COUNT(*) FROM usuarios WHERE nombre_usuario = @Usuario AND contrasena = @Contrasena";
                    SqlCommand command = new SqlCommand(consulta, conexion);
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contrasena", contrasena);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar las credenciales: " + ex.Message);
                    return false;
                }
                finally
                {
                    conexion.Close();
                }
            }

            return false;
        }

        /*
         * Componentes del formulario login
         */

        private void btn_login(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;          //Recibimos el [value] del label txtUsuario
            string passwd = txtContrasena.Text;     //Recibimos el [value] del label txtContrasena

            if (VerificarCredenciales(user, passwd))
            {
                frm_sysccab_menu mainMenu = new frm_sysccab_menu();
                mainMenu.Show();
                this.Hide();                        // Este formulario se oculta
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Inténtalo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_salir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
         * Metodos analogos de prueba para validar datos
         */

        private bool ValidarUsuario(string usuario, string contrasena)
        {
            if (usuario == "admin" && contrasena == "temporal2024")
            {
                return true;
            }
            else
                return false;
        }

        private void frm_sysccab_login_Load(object sender, EventArgs e)
        {

        }

        private void frm_titulo_login_Click(object sender, EventArgs e)
        {

        }
    }
}
