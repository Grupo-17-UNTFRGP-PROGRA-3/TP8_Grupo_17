<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="EliminarSucursal.aspx.cs" Inherits="Vistas.EliminarSucursal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Titulo de pagina-->
    <h1>Eliminar Sucursal</h1>
    <!--container general-->
    <div>

        Ingresar Id sucursal:<asp:TextBox ID="txtIdSucursal" runat="server"></asp:TextBox>
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtIdSucursal" ErrorMessage="Debe ingresar un número" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtIdSucursal" ErrorMessage="Solo ingrese números" ForeColor="Red" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>

    </div>
</asp:Content>
