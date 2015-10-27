<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grid.aspx.cs" Inherits="BaseDeDatosExpress.Grid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="CustomerID" DataSourceID="SqlDataSource1" PageSize="20">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" InsertVisible="False" ReadOnly="True" SortExpression="CustomerID" />
                <asp:BoundField DataField="PersonID" HeaderText="PersonID" SortExpression="PersonID" />
                <asp:BoundField DataField="StoreID" HeaderText="StoreID" SortExpression="StoreID" />
                <asp:BoundField DataField="TerritoryID" HeaderText="TerritoryID" SortExpression="TerritoryID" />
                <asp:BoundField DataField="AccountNumber" HeaderText="AccountNumber" ReadOnly="True" SortExpression="AccountNumber" />
                <asp:BoundField DataField="ModifiedDate" HeaderText="ModifiedDate" SortExpression="ModifiedDate" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorks2014ConnectionString %>" SelectCommand="SELECT CustomerID, PersonID, StoreID, TerritoryID, AccountNumber, ModifiedDate FROM Sales.Customer WHERE (CustomerID &gt; 100) and (CustomerID &lt; 500)"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
