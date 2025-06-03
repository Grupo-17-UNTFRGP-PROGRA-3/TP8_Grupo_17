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

        protected void btnFiltrarUnicoId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdSucursal3.Text);

            if (id > 0)
            {
                DataTable tablaSucursalesIdUnico = negocioSucursal.GetTablaId(id);
                gvSucursales.DataSource = tablaSucursalesIdUnico;
                gvSucursales.DataBind();
            }

            txtIdSucursal.Text = String.Empty;
            txtIdSucursal2.Text = String.Empty;
            txtIdSucursal3.Text = String.Empty;
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdSucursal.Text);
            int id2 = Convert.ToInt32(txtIdSucursal2.Text);

            if ((id > 0) && (id2 > 0))
            {
                if (id > id2) { int aux = id; id = id2; id2 = aux; }

                DataTable tablaSucursalesId = negocioSucursal.GetTablaId(id, id2);
                gvSucursales.DataSource = tablaSucursalesId;
                gvSucursales.DataBind();
            }

            txtIdSucursal.Text = String.Empty;
            txtIdSucursal2.Text = String.Empty;
            txtIdSucursal3.Text = String.Empty;
        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtIdSucursal.Text = String.Empty;
            txtIdSucursal2.Text = String.Empty;
            DataTable tablaSucursales = negocioSucursal.GetTabla();
            gvSucursales.DataSource = tablaSucursales;
            gvSucursales.DataBind();
        }
    }
}