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
                ddlProvincia.DataValueField = "Id_Provincia";
                ddlProvincia.DataSource = tablaProvincias;
                ddlProvincia.DataBind();
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            NegocioSucursal negocioSucursal = new NegocioSucursal();

            negocioSucursal.AgregarSucursal(txtNombreSucursal.Text, txtDescripcion.Text, Convert.ToInt32(ddlProvincia.SelectedValue), txtDireccion.Text);
        }
    }
}