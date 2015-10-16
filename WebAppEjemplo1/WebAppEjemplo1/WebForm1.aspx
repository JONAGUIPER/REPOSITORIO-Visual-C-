<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppEjemplo1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="css/estilos.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" CssClass="cambiaColor" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" CssClass="cambiaColor" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />
            <asp:ListBox ID="ListBox1" runat="server">
                <asp:ListItem Value="1">UNO</asp:ListItem>
                <asp:ListItem Value="2">DOS</asp:ListItem>
                <asp:ListItem Value="3">TRES</asp:ListItem>
            </asp:ListBox>
        </div>


    </form>
</body>
</html>
