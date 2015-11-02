<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tiendas.aspx.cs" Inherits="LoginADO.Tiendas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblWelcome" runat="server" Text="Hola: "></asp:Label>
        <br />
        <h1>
            <asp:Label ID="Label2" runat="server" Text="TIENDAS"></asp:Label>
        </h1>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Id de tienda:  "></asp:Label>
        <asp:DropDownList ID="ddIdTiendas" runat="server"></asp:DropDownList>
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
        <br />
        <asp:Label ID="lblEstado" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtPersonID" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtDemografia" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtModificacion" runat="server"></asp:TextBox>
        <br />
        <asp:GridView ID="gvTiendas" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gvTiendas_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ButtonType="Button" ShowSelectButton="True"></asp:CommandField>
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
    </form>
</body>
</html>
