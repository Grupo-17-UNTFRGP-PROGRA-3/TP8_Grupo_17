using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincia
    {
        public int _Id_Provincia;
        public string _DescripcionProvincia;

        public Provincia()
        {

        }
        public int getId_Provincia()
        {
            return _Id_Provincia;
        }
        public void setId_Provincia(int idProvincia)
        {
            _Id_Provincia = idProvincia;
        }

        public string getDescripcionProvincia()
        {
            return _DescripcionProvincia;
        }
        public void setDescripcionProvincia(string DescripcionProvincia)
        {
            _DescripcionProvincia = DescripcionProvincia;
        }
    }
}
