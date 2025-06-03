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
            lbtn_ConfirmarEliminar.Visible = true;
            lbtn_ConfirmarEliminar.Enabled = true;
            lbtn_ConfirmarEliminar0.Enabled = true;
            lbtn_ConfirmarEliminar0.Visible = true;
        }

        protected void lbtn_ConfirmarEliminar_Click(object sender, EventArgs e)
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
                    lbl_Mensaje.Text = "No se encontró una sucursal con el ID ingresado";
                }
                DataTable tablaSucursales = negocioSucursal.GetTabla();
                gvSucursales.DataSource = tablaSucursales;
                gvSucursales.DataBind();
                txt_IdSucursal.Text = string.Empty;
                lbtn_ConfirmarEliminar.Enabled = false;
                lbtn_ConfirmarEliminar.Visible = false;
                lbtn_ConfirmarEliminar0.Enabled = false;
                lbtn_ConfirmarEliminar0.Visible = false;
            }
            catch 
            {
                lbl_Mensaje.Text= string.Empty;
                return;
            }
        }

        protected void lbtn_ConfirmarEliminar0_Click(object sender, EventArgs e)
        {
            txt_IdSucursal.Text = string.Empty ;
            lbtn_ConfirmarEliminar.Enabled = false;
            lbtn_ConfirmarEliminar.Visible = false;
            lbtn_ConfirmarEliminar0.Enabled = false;
            lbtn_ConfirmarEliminar0.Visible = false;
            lbl_Mensaje.Text = string.Empty;
        }
    }
}