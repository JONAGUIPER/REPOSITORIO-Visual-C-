<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Db.aspx.cs" Inherits="Database.Db" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnClientes" runat="server" Text="Clientes" OnClick="btnClientes_Click" />
        <asp:GridView ID="verTabla" runat="server">

        </asp:GridView>
    </div>
    </form>
</body>
</html>
