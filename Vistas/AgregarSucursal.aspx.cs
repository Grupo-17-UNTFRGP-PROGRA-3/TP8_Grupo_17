using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!IsPostBack)
            {
                DataTable tablaProvincias = negocioProvincia.GetTabla();
                ddlProvincia.DataTextField = "DescripcionProvincia";
                ddlProvincia.DataValueField = "Id_Provincia";
                ddlProvincia.DataSource = tablaProvincias;
                ddlProvincia.DataBind();
                ddlProvincia.Items.Insert(0, new ListItem("--Seleccionar--", ""));
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            NegocioSucursal negocioSucursal = new NegocioSucursal();

             if(negocioSucursal.AgregarSucursal(txtNombreSucursal.Text, txtDescripcion.Text, Convert.ToInt32(ddlProvincia.SelectedValue), txtDireccion.Text))
            {
                lblMensaje.Text = "La sucursal se ha agregado con éxito";
                lblMensaje.ForeColor = Color.Green;
                txtNombreSucursal.Text = "";
                txtDescripcion.Text = "";
                ddlProvincia.SelectedIndex = 0;
                txtDireccion.Text = "";
            }
        }
    }
}