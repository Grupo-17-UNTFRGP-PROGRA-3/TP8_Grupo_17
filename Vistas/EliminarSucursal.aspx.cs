using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Vistas
{
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            NegocioSucursal ns = new NegocioSucursal();
            if (ns.EliminarSucursal(txt_IdSucursal.Text))
            {
                txt_IdSucursal.Text = string.Empty;
                lbl_Mensaje.Text = "Sucursal eliminada!!";
            }
        }
    }
}