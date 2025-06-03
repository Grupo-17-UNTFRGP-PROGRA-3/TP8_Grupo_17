<%@ Page Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ListadoSucursales.aspx.cs" Inherits="Vistas.ListadoSucursales" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Titulo de pagina-->
    <h1>Listado de Sucursales</h1>

    <!--General-->
    <div>

        Ingrese rango de Id sucursal:<asp:TextBox ID="txtIdSucursal" runat="server" TextMode="Number"></asp:TextBox>
        <asp:TextBox ID="txtIdSucursal2" runat="server" TextMode="Number"></asp:TextBox>
        <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" ValidationGroup="G3" />
        <asp:Button ID="btnMostrarTodos" runat="server" Text="Mostrar todos" OnClick="btnMostrarTodos_Click" />
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtIdSucursal" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="#FF3300" ValidationGroup="G3">Debe ingresar datos en el primer campo</asp:RequiredFieldValidator>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtIdSucursal2" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="#FF3300" ValidationGroup="G3">Debe ingresar datos en segundo campo</asp:RequiredFieldValidator>

        <br />

    </div>
    <!--Gridview-->
    <div>
        <asp:GridView runat="server" ID="gvSucursales" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="mensajeError" EmptyDataText="No se han encontrado coincidencias">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="Id">
                    <ItemTemplate>
                        &nbsp;<asp:Label ID="lbl_it_idSucursal" runat="server" Text='<%# Bind("Id_Sucursal") %>'></asp:Label>
                        &nbsp;
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre">
                    <ItemTemplate>
                        &nbsp;<asp:Label ID="lbl_it_NombreSucursal" runat="server" Text='<%# Bind("NombreSucursal") %>'></asp:Label>
                        &nbsp;
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Descripcion">
                    <ItemTemplate>
                        &nbsp;<asp:Label ID="lbl_it_Descripcion" runat="server" Text='<%# Bind("DescripcionSucursal") %>'></asp:Label>
                        &nbsp;
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Provincia">
                    <ItemTemplate>
                        &nbsp;<asp:Label ID="lbl_it_Provincia" runat="server" Text='<%# Bind("DescripcionProvincia") %>'></asp:Label>
                        &nbsp;
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Direccion">
                    <ItemTemplate>
                        &nbsp;<asp:Label ID="lbl_it_Direccion" runat="server" Text='<%# Bind("DireccionSucursal") %>'></asp:Label>
                        &nbsp;
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>
</asp:Content>

