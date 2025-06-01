<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="EliminarSucursal.aspx.cs" Inherits="Vistas.EliminarSucursal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Titulo de pagina-->
    <h1>Eliminar Sucursal</h1>
    <!--container general-->
    <div style="height: 148px">

        Ingresar Id sucursal:<asp:TextBox ID="txt_IdSucursal" runat="server" ValidationGroup="G2"></asp:TextBox>
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" ValidationGroup="G2" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_IdSucursal" ErrorMessage="Debe ingresar un número" ForeColor="Red" ValidationGroup="G2" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_IdSucursal" ErrorMessage="Solo ingrese números" ForeColor="Red" ValidationExpression="^[0-9]+$" ValidationGroup="G2" Display="Dynamic"></asp:RegularExpressionValidator>

        <br />
        <asp:Label ID="lbl_Mensaje" runat="server"></asp:Label>

    </div>
</asp:Content>
