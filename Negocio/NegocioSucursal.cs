using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioSucursal
    {
        public DataTable GetTabla()
        {
            DaoSucursal dao = new DaoSucursal();
            return dao.ObtenerSucursalesIJProvincias();
        }
    }
}
