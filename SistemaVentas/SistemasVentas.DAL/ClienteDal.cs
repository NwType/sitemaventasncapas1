using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClienetesDal()
        {
            string consulta = "select * from cliente";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InserarClienteDal(Cliente c)
        {
            string consulta = "insert into cliente values ("+ c.IdPersona + ",'" +
                c.TipoCliente + "','" + c.CodigoCliente + "','Activos')";
            conexion.Ejecutar(consulta);
        }

    }
}
