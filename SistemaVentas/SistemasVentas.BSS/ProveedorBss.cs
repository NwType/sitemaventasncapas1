﻿using SistemasVentas.DAL;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class ProveedorBss
    {
        ProveedorDal dal= new ProveedorDal();
        public DataTable ListarProveedorBss()
        {
            return dal.ListarProveedorDal();
        }
        public void InsertarProveedorBss(Proveedor p)
        {
            dal.InsertarProveedorDal(p);
        }
    }
}
