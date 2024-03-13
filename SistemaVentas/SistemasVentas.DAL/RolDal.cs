using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class RolDal
    {
        public DataTable ListarRolDal()
        {
            string consulta = "select * from rol";
            DataTable listar = conexion.EjecutarDataTabla(consulta, "listar");
            return listar;
        }
    }
}
