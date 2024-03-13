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
            //Application.Run(new PersonaVistas.PersonaListarVista());
            //Application.Run(new ClientesVistas.ClientesListarVista());
            //Application.Run(new UsuarioVistas.UsuarioListarVista());
            //Application.Run(new ProveedorVistas.ProveedorListarVista());
            //Application.Run(new ProductoVistas.ProductoListarVista());
            //Application.Run(new MarcaVistas.MarcaListarVista());
            //Application.Run(new ProveeVistas.ProveeListarVistas());
            //Application.Run(new DetalleingVistas.DetalleingListarVista());
            //Application.Run(new IngresoVistas.IngresoListarVista());
            //Application.Run(new TipoProdVistas.TipoProdListarVista());
            //Application.Run(new UsuarioRolVista.UsuarioRolListarVista());
            //Application.Run(new VentaVistas.VentaListarVista());
            //Application.Run(new DetalleVentaVistas.DetalleVentaListarVenta());
            Application.Run(new RolVistas.RolListarVista());
        }
    }
}