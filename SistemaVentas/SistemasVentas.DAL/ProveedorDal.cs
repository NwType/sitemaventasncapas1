﻿using SistemaVentas.Modelos;
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
        public Proveedor ObtenerProveedorId(int id)
        {
            string consulta = "select * from proveedor where idproveedor=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "ya");
            Proveedor p= new Proveedor();
            if (tabla.Rows.Count > 0)
            {
                p.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idproveedor"]);
                p.nombre = tabla.Rows[0]["nombre"].ToString();
                p.telefono = tabla.Rows[0]["telefono"].ToString();
                p.direccion= tabla.Rows[0]["direccion"].ToString();
            }
            return p;
        }
        public void EditarProveedorDal(Proveedor p)
        {
            string consulta = "UPDATE proveedor SET nombre = '" + p.nombre + "', telefono = '" + p.telefono + "', direccion = '" + p.direccion + "' WHERE idProveedor = " + p.IdProveedor;

            conexion.Ejecutar(consulta);
        }
        public void EliminarProveedorDal(int id)
        {
            string consulta = "DELETE FROM proveedor WHERE idproveedor = " + id;

            conexion.Ejecutar(consulta);
        }
    }
}
