using form_sysccab_menu;
using form_sysccab_menu.Expedientes;

namespace form_sysccab
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Expedientes_de_clientes());
        }
    }
}