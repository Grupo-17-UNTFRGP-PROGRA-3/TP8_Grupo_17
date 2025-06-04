using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Vistas
{
    public partial class EliminarSucursal : System.Web.UI.Page
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

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            lbl_Mensaje.Text = string.Empty;

            lblConfirmacionEliminacion.Visible = true;
            lblConfirmacionEliminacion.Enabled = true;

            btnAceptarEliminacion.Visible = true;
            btnAceptarEliminacion.Enabled = true;

            btnCancelaEliminacion.Visible = true;
            btnCancelaEliminacion.Enabled = true;
        }

        protected void btnAceptarEliminacion_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioSucursal ns = new NegocioSucursal();

                if (ns.EliminarSucursal(txt_IdSucursal.Text))
                {
                    lbl_Mensaje.ForeColor = Color.Red;
                    lbl_Mensaje.Text = "La sucursal se ha eliminado con éxito";
                }
                else
                {
                    lbl_Mensaje.ForeColor = Color.Black;
                    lbl_Mensaje.Text = "No se encontró una sucursal con el ID " + txt_IdSucursal.Text.ToString();
                }

                DataTable tablaSucursales = negocioSucursal.GetTabla();
                gvSucursales.DataSource = tablaSucursales;
                gvSucursales.DataBind();

                txt_IdSucursal.Text = string.Empty;

                lblConfirmacionEliminacion.Enabled = false;
                lblConfirmacionEliminacion.Visible = false;

                btnAceptarEliminacion.Visible = false;
                btnAceptarEliminacion.Enabled = false;
                btnCancelaEliminacion.Visible = false;
                btnCancelaEliminacion.Enabled = false;
            }
            catch
            {
                lbl_Mensaje.Text = string.Empty;
                return;
            }
        }

        protected void btnCancelaEliminacion_Click(object sender, EventArgs e)
        {
            lblConfirmacionEliminacion.Enabled = false;
            lblConfirmacionEliminacion.Visible = false;

            btnAceptarEliminacion.Visible = false;
            btnAceptarEliminacion.Enabled = false;
            btnCancelaEliminacion.Visible = false;
            btnCancelaEliminacion.Enabled = false;
        }
    }
}