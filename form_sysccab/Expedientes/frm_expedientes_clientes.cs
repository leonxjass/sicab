using form_sysccab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_sysccab_menu.Expedientes
{
    public partial class Expedientes_de_clientes : Form
    {
        public Expedientes_de_clientes()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.Run(new frm_sysccab_login());
        }
    }
}
