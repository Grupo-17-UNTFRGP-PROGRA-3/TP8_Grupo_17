using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        public int _id_sucursal;
        public string _nombreSucursal;
        public string _descripcionSucursal;
        public int _id_horarioSucursal;
        public int _id_provinciaSucursal;
        public string _direccionSucursal;
        public string _URL_imagenSucursal;

        public Sucursal()
        {   }
        public int getId_sucursal()
        {
            return _id_sucursal;
        }
        public void setId_sucursal(int id_sucursal)
        {
            _id_sucursal = id_sucursal;
        }
        public string getNombreSucursal()
        {
            return _nombreSucursal;
        }
        public void setNombreSucursal(string nombreSucursal)
        {
            _nombreSucursal = nombreSucursal;
        }
        public string getDescripcionSucursal()
        {
            return _descripcionSucursal;
        }
        public void setDescripcionSucursal(string descripcionSucursal)
        {
            _descripcionSucursal = descripcionSucursal;
        }
        public int getId_horarioSucursal()
        {
            return _id_horarioSucursal;
        }
        public void setId_horarioSucursal(int id_horarioSucursal)
        {
            _id_horarioSucursal = id_horarioSucursal;
        }
        public int getId_provinciaSucursal()
        {
            return _id_provinciaSucursal;
        }
        public void setId_provinciaSucursal(int id_provinciaSucursal)
        {
            _id_provinciaSucursal = id_provinciaSucursal;
        }
        public string getDireccionSucursal()
        {
            return _direccionSucursal;
        }
        public void setDireccionSucursal(string direccionSucursal)
        {
            _direccionSucursal = direccionSucursal;
        }
        public string getURL_imagenSucursal()
        {
            return _URL_imagenSucursal;
        }
        public void setURL_imagenSucursal(string URL_imagenSucursal)
        {
            _URL_imagenSucursal = URL_imagenSucursal;
        }
    }
}
