<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="EliminarSucursal.aspx.cs" Inherits="Vistas.EliminarSucursal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Titulo de pagina-->
    <h1>Eliminar Sucursal</h1>

    <!--container general-->
    <div style="height: 148px">
        Ingresar Id sucursal:<asp:TextBox ID="txt_IdSucursal" runat="server" ValidationGroup="G2" TextMode="Number"></asp:TextBox>
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" ValidationGroup="G2" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_IdSucursal" ErrorMessage="Debe ingresar un número" ForeColor="Red" ValidationGroup="G2"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_IdSucursal" ErrorMessage="Solo ingrese números" ForeColor="Red" ValidationExpression="^[0-9]+$" ValidationGroup="G2"></asp:RegularExpressionValidator>

        <br />
        <!--container Confirmacion de eliminacion-->
        <div>
            <br />
            <asp:Label ID="lblConfirmacionEliminacion" runat="server" Text="¿Seguro que desea eliminar la sucursal?" Enabled="False" Visible="False"></asp:Label>
            <br />
            <div style="display: flex; gap: 15px;">
                <asp:Button ID="btnAceptarEliminacion" runat="server" Text="Eliminar" Enabled="False" Visible="False" OnClick="btnAceptarEliminacion_Click" />
                <asp:Button ID="btnCancelaEliminacion" runat="server" Text="Cancelar" Enabled="False" Visible="False" OnClick="btnCancelaEliminacion_Click" />
            </div>
        </div>
       
        <br />
        <asp:Label ID="lbl_Mensaje" runat="server"></asp:Label>
        <br />
        <br />

        <!--container Gridview-->
        <div>
            <asp:GridView runat="server" ID="gvSucursales" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
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
        
    </div>
</asp:Content>
