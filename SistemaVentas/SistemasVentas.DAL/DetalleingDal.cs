using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleingDal
    {
        public DataTable ListarDetalleingDal()
        {
            string consulta = "select * from detalleing";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarDetalleVentaDal(DetalleIng di)
        {
            string fechaFormateada = di.FechaVenc.ToString("yyyy-MM-dd HH:mm:ss");
            string consulta = "insert into detalleing values (" + di.IdIngreso + ", " + di.IdProducto + ", " + di.PrecioVenta + ", '" 
                + fechaFormateada + "', " + di.Cantidad + ", " + di.PrecioCosto + ", " + di.PrecioVenta + ", " + di.Subtotal + ", 'Activo')";
            conexion.Ejecutar(consulta);
        }
        public DataTable ListarDetalleinAdmgDal()
        {
            string consulta = @"
    SELECT DI.IDDETALLEING, I.IDINGRESO, P.NOMBRE AS NOMBRE_PRODUCTO, DI.FECHAVENC, DI.CANTIDAD, DI.PRECIOCOSTO, DI.PRECIOVENTA, DI.SUBTOTAL, DI.ESTADO
    FROM DETALLEING DI
    INNER JOIN INGRESO I ON DI.IDINGRESO = I.IDINGRESO
    INNER JOIN PRODUCTO P ON DI.IDPRODUCTO = P.IDPRODUCTO;";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
