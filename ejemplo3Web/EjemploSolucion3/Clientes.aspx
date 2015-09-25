<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="EjemploSolucion3.Clientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="NeptunoDataSource">
            <Columns>
                <asp:BoundField DataField="NombreContacto" HeaderText="NombreContacto" SortExpression="NombreContacto" />
                <asp:BoundField DataField="CargoContacto" HeaderText="CargoContacto" SortExpression="CargoContacto" />
                <asp:BoundField DataField="NombreCompañía" HeaderText="NombreCompañía" SortExpression="NombreCompañía" />
                <asp:BoundField DataField="País" HeaderText="País" SortExpression="País" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="NeptunoDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:NeptunoConnectionString %>" ProviderName="<%$ ConnectionStrings:NeptunoConnectionString.ProviderName %>" SelectCommand="SELECT [NombreContacto], [CargoContacto], [NombreCompañía], [País] FROM [Clientes]"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
