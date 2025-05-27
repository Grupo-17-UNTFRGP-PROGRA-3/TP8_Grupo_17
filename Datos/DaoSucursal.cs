using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
