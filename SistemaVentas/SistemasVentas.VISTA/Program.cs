namespace SistemasVentas.VISTA
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
            //Application.Run(new AdministradorVista.AdministradorVista());
            //Application.Run(new AdministradorAlmacenVista.AdministradorAlmacenVista());
            //Application.Run(new VendedorVista.AnadirVentaVista());
            Application.Run(new AdministradorAlmacenVista.ProveedorVista());
        }
    }
}