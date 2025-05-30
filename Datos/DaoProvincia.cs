using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public  class DaoProvincia
    {
        AccesoDatos accesoDatos = new AccesoDatos();
        public DataTable ObtenerProvincias()
        {
            string consultaSQL = "Select * FROM Provincia";
            return accesoDatos.ObtenerTablas(consultaSQL, "Provincias");
        }

    }
}
