using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class VentaDal
    {
        public DataTable ListarVentaDal()
        {
            string consulta = "select * from venta";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarVentaDal(Venta v)
        {
            string fechaFormateada = v.Fecha.ToString("yyyy-MM-dd HH:mm:ss");
            string consulta = "INSERT INTO venta VALUES (" + v.IdCliente + "," + v.IdVendedor + ",'" + fechaFormateada + "'," + v.Total + ",'Activo')";
            conexion.Ejecutar(consulta);
        }

    }
}
