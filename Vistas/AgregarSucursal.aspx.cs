using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        NegocioProvincia negocioProvincia = new NegocioProvincia();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable tablaProvincias = negocioProvincia.GetTabla();
                ddlProvincia.DataTextField = "DescripcionProvincia";
                ddlProvincia.DataValueField = "DescripcionProvincia";
                ddlProvincia.DataSource = tablaProvincias;
                ddlProvincia.DataBind();
            }
        }
    }
}