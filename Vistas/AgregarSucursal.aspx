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
                    <asp:RequiredFieldValidator ID="rfv_NombreSucursal" runat="server" ControlToValidate="txtNombreSucursal" ForeColor="#FF3300" ValidationGroup="G1">Debe ingresar un nombre de sucursal</asp:RequiredFieldValidator>
                </div>
                <div>
                    <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfv_Descripcion" runat="server" ControlToValidate="txtDescripcion" ForeColor="#FF3300" ValidationGroup="G1">Debe ingresar una descripcion</asp:RequiredFieldValidator>
                </div>
            <div>
                <asp:DropDownList ID="ddlProvincia" runat="server">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfv_Provincia" runat="server" ControlToValidate="ddlProvincia" Display="Dynamic" ErrorMessage="Debe seleccionar una provincia" ForeColor="#FF3300" ValidationGroup="G1"></asp:RequiredFieldValidator>
            </div>

            <div>
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_Direccion" runat="server" ControlToValidate="txtDireccion" ForeColor="#FF3300" ValidationGroup="G1">Debe ingresar una direccion</asp:RequiredFieldValidator>
            </div>

            <!--container boton-->
            <div>
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" ValidationGroup="G1" />
                <br />
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                <br />
            </div>
        </div>
    </div>
</asp:Content>
