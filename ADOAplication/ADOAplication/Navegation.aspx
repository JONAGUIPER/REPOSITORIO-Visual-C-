<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Navegation.aspx.cs" Inherits="ADOAplication.Navegation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnGoToAdd" runat="server" Text="Agregar una Cuenta" Height="26px" PostBackUrl="~/NewCustomer.aspx" />
        <br />
        <br />
        <asp:Button ID="btnGoToFillOrCancel" runat="server" Text="Llenar o Cancelar una Orden" PostBackUrl="~/FillOrCancel.aspx" />
        <br />
        <br />
        <asp:Button ID="btnExit" runat="server" OnClick="Button3_Click" Text="Salir" />
    </div>
       
    </form>
</body>
</html>
