using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class DetalleingBss
    {
        DetalleingDal dal= new DetalleingDal();
        public DataTable ListarDetalleingBss()
        {
            return dal.ListarDetalleingDal();
        }
    }
}
