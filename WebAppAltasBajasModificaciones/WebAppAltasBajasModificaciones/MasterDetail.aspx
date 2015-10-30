<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MasterDetail.aspx.cs" Inherits="WebAppAltasBajasModificaciones.MasterDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        <div>
            <asp:Label ID="lblID" runat="server" Text="Introduce un ID (del 1 al 10):"></asp:Label>
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            <asp:Button ID="btnVer" runat="server" Text="Ver Cliente" />
            <asp:GridView ID="GridViewClientes" runat="server" DataSourceID="SqlDataSource1"></asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorks2014ConnectionString %>" SelectCommand="SELECT * FROM Sales.Customer WHERE CustomerID = @CustomerID">
                <SelectParameters>
                    <asp:ControlParameter ControlID="txtID" DefaultValue="1" Name="CustomerID" PropertyName="Text" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
