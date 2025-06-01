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
    public partial class ListadoSucursales : System.Web.UI.Page
    {
        NegocioSucursal negocioSucursal = new NegocioSucursal();
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!IsPostBack)
            {
                DataTable tablaSucursales = negocioSucursal.GetTabla();
                gvSucursales.DataSource = tablaSucursales;
                gvSucursales.DataBind();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdSucursal.Text))
                return;

            DataTable tablaSucursalesId = negocioSucursal.GetTablaId(Convert.ToInt32(txtIdSucursal.Text));
            gvSucursales.DataSource = tablaSucursalesId;
            gvSucursales.DataBind();
        }
    }
}