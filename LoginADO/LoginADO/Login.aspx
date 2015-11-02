<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginADO.Login" %>

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
            <asp:Label ID="Label3" runat="server" Text="Login"></asp:Label>
        </h1>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Usuario:  "></asp:Label>
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password:  "></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnEntrar" runat="server" OnClick="btnEntrar_Click" Text="Entrar" />
        <br />
        <br />
        <asp:LinkButton ID="lkbRegistrarse" runat="server" PostBackUrl="~/Register.aspx">Registrarse</asp:LinkButton>
        <br />
        <asp:Label ID="lblEstado" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
