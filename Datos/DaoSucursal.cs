using System;
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

        public int AgregarSucursal(Sucursal suc)
        {            
            string consulta = "INSERT INTO Sucursal (NombreSucursal, DescripcionSucursal, Id_ProvinciaSucursal, DireccionSucursal) VALUES('" +
                                     suc.getNombreSucursal() + "', '" +
                                     suc.getDescripcionSucursal() + "', '" +
                                     suc.getId_provinciaSucursal() + "', '" +
                                     suc.getDireccionSucursal() + "')";

            return accesoDatos.EjecutarConsulta(consulta);
        }
    }
}
