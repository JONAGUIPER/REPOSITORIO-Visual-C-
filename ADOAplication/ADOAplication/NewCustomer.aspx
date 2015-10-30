<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewCustomer.aspx.cs" Inherits="ADOAplication.NewCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>
            <asp:Label ID="Label1" runat="server" Text="Agregar Cuenta"></asp:Label>
        </h1>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nombre:  "></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="ID:  "></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCreateAccount" runat="server" OnClick="btnCreateAccount_Click" Text="Crear Cuenta" />
        <br />
        <asp:Label ID="lblEstado" runat="server"></asp:Label>
        <br />
        <br />
        <h1>
            <asp:Label ID="Label4" runat="server" Text="Crear Orden"></asp:Label>
        </h1>
        <asp:Label ID="Label5" runat="server" Text="Orden Amount"></asp:Label>
        <asp:TextBox ID="numOrderAmount" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Fecha de Orden"></asp:Label>
        <asp:TextBox ID="dtpOrderDate" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnPlaceOrder" runat="server" OnClick="btnPlaceOrder_Click" Text="Cargar Orden" />
        <br />
        <asp:Label ID="lblEstado2" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnAddAnotherAccount" runat="server" PostBackUrl="~/Navegation.aspx" Text="Finalizar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAddFinish" runat="server" OnClick="btnAddFinish_Click" Text="Crear Otra Orden" />
    
    </div>
    </form>
</body>
</html>
