<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="Vistas.AgregarSucursal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Titulo de pagina-->
    <h1>Agregar Sucursal</h1>

    <!--container general-->
    <div style="display: flex; flex-direction: row; gap: 10px;">
        <!--container labels-->
        <div style="display: flex; flex-direction: column; gap: 10px;">
            <div>
                <asp:Label ID="lblNombreSucursal" runat="server" Text="Nombre Sucursal: "></asp:Label>
            </div>

            <div>
                <asp:Label ID="lblDescripcion" runat="server" Text="Descripcion: "></asp:Label>
            </div>

            <div>
                <asp:Label ID="lblProvincia" runat="server" Text="Provincia: "></asp:Label>
            </div>

            <div>
                <asp:Label ID="lblDireccion" runat="server" Text="Direccion: "></asp:Label>
            </div>
        </div>

        <!--container textboxes-->
        <div style="display: flex; flex-direction: column; gap: 10px;">
            <div>
                <asp:TextBox ID="txtNombreSucursal" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:DropDownList ID="ddlProvincia" runat="server">
                </asp:DropDownList>
            </div>

            <div>
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            </div>

            <!--container boton-->
            <div>
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
            </div>
        </div>
    </div>
</asp:Content>
