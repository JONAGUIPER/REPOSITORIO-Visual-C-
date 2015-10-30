<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TiendasClientes.aspx.cs" Inherits="WebAppAltasBajasModificaciones.TiendasClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <div>
                <asp:GridView ID="GridViewTiendas" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="BusinessEntityID">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="BusinessEntityID" HeaderText="BusinessEntityID" ReadOnly="True" SortExpression="BusinessEntityID" />
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                        <asp:BoundField DataField="SalesPersonID" HeaderText="SalesPersonID" SortExpression="SalesPersonID" />
                        <asp:BoundField DataField="Demographics" HeaderText="Demographics" SortExpression="Demographics" />
                        <asp:BoundField DataField="rowguid" HeaderText="rowguid" SortExpression="rowguid" />
                        <asp:BoundField DataField="ModifiedDate" HeaderText="ModifiedDate" SortExpression="ModifiedDate" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorks2014ConnectionString %>" SelectCommand="SELECT top 3 * FROM Sales.Store"></asp:SqlDataSource>
            </div>
            <div>
                <asp:GridView ID="GridViewClientes" runat="server" DataSourceID="SqlDataSource2" AutoGenerateColumns="False" DataKeyNames="CustomerID">
                    <Columns>
                        <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" InsertVisible="False" ReadOnly="True" SortExpression="CustomerID" />
                        <asp:BoundField DataField="PersonID" HeaderText="PersonID" SortExpression="PersonID" />
                        <asp:BoundField DataField="StoreID" HeaderText="StoreID" SortExpression="StoreID" />
                        <asp:BoundField DataField="TerritoryID" HeaderText="TerritoryID" SortExpression="TerritoryID" />
                        <asp:BoundField DataField="AccountNumber" HeaderText="AccountNumber" ReadOnly="True" SortExpression="AccountNumber" />
                        <asp:BoundField DataField="rowguid" HeaderText="rowguid" SortExpression="rowguid" />
                        <asp:BoundField DataField="ModifiedDate" HeaderText="ModifiedDate" SortExpression="ModifiedDate" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorks2014ConnectionString %>" SelectCommand="SELECT * FROM Sales.Customer where storeid = @storeid">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="GridViewTiendas" DefaultValue="1" Name="storeid" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </div>
        </div>

    </form>
</body>
</html>
