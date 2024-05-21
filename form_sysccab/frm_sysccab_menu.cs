namespace form_sysccab
{
    public partial class frm_sysccab_menu : Form
    {
        public frm_sysccab_menu()
        {
            InitializeComponent();
        }

        private void listadoDeClientesDeMoraPorRangoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void expedientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_sysccab_menu.Expedientes.Expedientes_de_clientes expedientesDeClientes = new form_sysccab_menu.Expedientes.Expedientes_de_clientes();
            expedientesDeClientes.Show();
            this.Hide();
        }
    }
}
