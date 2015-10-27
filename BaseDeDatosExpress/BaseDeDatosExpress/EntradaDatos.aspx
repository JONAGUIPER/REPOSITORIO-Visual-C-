<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EntradaDatos.aspx.cs" Inherits="BaseDeDatosExpress.EntradaDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="FORMVIEW A PARTIR DE INTERFAZ GRAFICA"></asp:Label>
        <br />
        <asp:FormView ID="FormView1" runat="server" DataKeyNames="CustomerID" DataSourceID="SqlDataSource1">
            <EditItemTemplate>
                CustomerID:
                <asp:Label ID="CustomerIDLabel1" runat="server" Text='<%# Eval("CustomerID") %>' />
                <br />
                PersonID:
                <asp:TextBox ID="PersonIDTextBox" runat="server" Text='<%# Bind("PersonID") %>' />
                <br />
                StoreID:
                <asp:TextBox ID="StoreIDTextBox" runat="server" Text='<%# Bind("StoreID") %>' />
                <br />
                TerritoryID:
                <asp:TextBox ID="TerritoryIDTextBox" runat="server" Text='<%# Bind("TerritoryID") %>' />
                <br />
                AccountNumber:
                <asp:TextBox ID="AccountNumberTextBox" runat="server" Text='<%# Bind("AccountNumber") %>' />
                <br />
                ModifiedDate:
                <asp:TextBox ID="ModifiedDateTextBox" runat="server" Text='<%# Bind("ModifiedDate") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Actualizar" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </EditItemTemplate>
            <InsertItemTemplate>
                PersonID:
                <asp:TextBox ID="PersonIDTextBox" runat="server" Text='<%# Bind("PersonID") %>' />
                <br />
                StoreID:
                <asp:TextBox ID="StoreIDTextBox" runat="server" Text='<%# Bind("StoreID") %>' />
                <br />
                TerritoryID:
                <asp:TextBox ID="TerritoryIDTextBox" runat="server" Text='<%# Bind("TerritoryID") %>' />
                <br />
                AccountNumber:
                <asp:TextBox ID="AccountNumberTextBox" runat="server" Text='<%# Bind("AccountNumber") %>' />
                <br />
                ModifiedDate:
                <asp:TextBox ID="ModifiedDateTextBox" runat="server" Text='<%# Bind("ModifiedDate") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insertar" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </InsertItemTemplate>
            <ItemTemplate>
                CustomerID:
                <asp:Label ID="CustomerIDLabel" runat="server" Text='<%# Eval("CustomerID") %>' />
                <br />
                PersonID:
                <asp:Label ID="PersonIDLabel" runat="server" Text='<%# Bind("PersonID") %>' />
                <br />
                StoreID:
                <asp:Label ID="StoreIDLabel" runat="server" Text='<%# Bind("StoreID") %>' />
                <br />
                TerritoryID:
                <asp:Label ID="TerritoryIDLabel" runat="server" Text='<%# Bind("TerritoryID") %>' />
                <br />
                AccountNumber:
                <asp:Label ID="AccountNumberLabel" runat="server" Text='<%# Bind("AccountNumber") %>' />
                <br />
                ModifiedDate:
                <asp:Label ID="ModifiedDateLabel" runat="server" Text='<%# Bind("ModifiedDate") %>' />
                <br />
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Editar" />
                &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Eliminar" />
                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="Nuevo" />
            </ItemTemplate>
        </asp:FormView>
    
        <br />


        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorks2014ConnectionString %>" SelectCommand="SELECT CustomerID, PersonID, StoreID, TerritoryID, AccountNumber, ModifiedDate FROM Sales.Customer" UpdateCommand="UPDATE Sales.Customer SET ModifiedDate = @ModifiedDate WHERE (CustomerID = @CustomerID)" DeleteCommand="Delete Sales.Customer WHERE (CustomerID = @CustomerID)" InsertCommand="INSERT INTO Sales.Customer(CustomerID, PersonID, StoreID, TerritoryID, ModifiedDate) VALUES (@CustomerID, @PersonID, @StoreID, @TerritoryID, GETDATE())">
            <UpdateParameters>
                <asp:Parameter Name="CustomerID" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="FORMVIEW A PARTIR DE CODIGO"></asp:Label>
        <br />
        <asp:FormView ID="fvCodigo" runat="server">
        </asp:FormView>
    
    </div>
    </form>
</body>
</html>
