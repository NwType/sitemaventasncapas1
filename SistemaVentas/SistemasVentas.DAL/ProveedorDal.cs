using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProveedorDal
    {
        public DataTable ListarProveedorDal()
        {
            string consulta = "select * from proveedor";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarProveedorDal(Proveedor p)
        {
            string consulta = "insert into proveedor values('" + p.nombre + "'," +
            "'" + p.telefono + "'," +
            "'" + p.direccion + "'," +"'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
