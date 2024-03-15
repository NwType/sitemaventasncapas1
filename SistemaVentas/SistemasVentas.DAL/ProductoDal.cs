using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProductoDal
    {
          public DataTable ListarProductoDal()
        {
            string consulta = "select * from producto";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarProductoDal(Producto p)
        {
            string consulta = "INSERT INTO producto values (" + p.IdTipoProd + ", " + p.IdMarca + ", '" + p.Nombre + "', '" + p.CodigoBarra + "', " + p.Unidad + ", '" + p.Descripcion + "', 'Activo')";
            conexion.Ejecutar(consulta);
        }

    }
}
