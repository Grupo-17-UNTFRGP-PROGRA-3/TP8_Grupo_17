using Datos;
using Entidades;
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

        public bool AgregarSucursal(string nombre, string descripcion, int provincia, string direccion)
        {
            int cantFilas = 0;

            Sucursal suc = new Sucursal();

            suc.setNombreSucursal(nombre);
            suc.setDescripcionSucursal(descripcion);
            suc.setId_provinciaSucursal(provincia);
            suc.setDireccionSucursal(direccion);

            DaoSucursal dao = new DaoSucursal();

            cantFilas = dao.AgregarSucursal(suc);

            if (cantFilas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarSucursal(string id_Sucursal)
        {
            DaoSucursal dao = new DaoSucursal();
            return dao.EliminarSucursal(id_Sucursal);
        }
    }
}
