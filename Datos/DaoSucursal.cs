﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DaoSucursal
    {
        AccesoDatos accesoDatos = new AccesoDatos();

        public DataTable ObtenerSucursales()
        {
            string consultaSQL = "SELECT * FROM Sucursal";
            return accesoDatos.ObtenerTablas(consultaSQL, "Sucursales");
        }
        
        public DataTable ObtenerSucursalesIJProvincias()
        {
            string consultaSQL = "SELECT * FROM Sucursal INNER JOIN Provincia ON Id_ProvinciaSucursal = Id_Provincia";
            return accesoDatos.ObtenerTablas(consultaSQL, "Sucursales");
        }

        public bool SucursalIdExiste(int id)
        {
            string consultaSQL = $"SELECT 1 FROM Sucursal WHERE Id_Sucursal = {id}";
            DataTable tabla = accesoDatos.ObtenerTablas(consultaSQL, "Sucursales");

            return tabla.Rows.Count > 0;
        }

        public DataTable ObtenerSucursalesIJProvinciasID(int id)
        {
            string consultaSQL = "SELECT * FROM Sucursal INNER JOIN Provincia ON Id_ProvinciaSucursal" +
                " = Id_Provincia WHERE Id_Sucursal = " + id.ToString();
            return accesoDatos.ObtenerTablas(consultaSQL, "Sucursales");
        }

        public DataTable ObtenerSucursalesIJProvinciasID(int id, int id2)
        {
            string consultaSQL = "SELECT * FROM Sucursal INNER JOIN Provincia ON Id_ProvinciaSucursal" +
                " = Id_Provincia WHERE Id_Sucursal BETWEEN " + id.ToString() +" AND " + id2.ToString();
            return accesoDatos.ObtenerTablas(consultaSQL, "Sucursales");
        }

        public int AgregarSucursal(Sucursal suc)
        {            
            string consulta = "INSERT INTO Sucursal (NombreSucursal, DescripcionSucursal, Id_ProvinciaSucursal, DireccionSucursal) VALUES('" +
                                     suc.getNombreSucursal() + "', '" +
                                     suc.getDescripcionSucursal() + "', '" +
                                     suc.getId_provinciaSucursal() + "', '" +
                                     suc.getDireccionSucursal() + "')";

            return accesoDatos.EjecutarConsulta(consulta);
        }
        public bool EliminarSucursal(string id_Sucursal)
        {
            string sqlCommand = "DELETE FROM Sucursal WHERE Id_Sucursal = " + id_Sucursal;
            int filasAfectadas = accesoDatos.EjecutarConsulta(sqlCommand);
            if (filasAfectadas > 0) { return true; }
            else { return false; }
        }
    }
}
