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

        private bool VerificarCredenciales(string usuario, string contrasena) 
        {
            /*
             * Poner aqui la logica de la conexion al sql server para instanciar la conexion
             * se debe comparar a los parametros del metodo con los campos [nombre_usuario] & [contrasena]
             * para validar la conexion y que lance el [main_menu] del sistema
             * Entonces se obtiene los datos de la DB y se comparan contra los parametros del metodo usando el parametro this
             */

            return false;
        }

        /*
         * Componentes del formulario login
         */

        private void btn_login(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;          //Recibimos el [value] del label txtUsuario
            string passwd = txtContrasena.Text;     //Recibimos el [value] del label txtContrasena

            if (ValidarUsuario(user, passwd))
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

    }
}
