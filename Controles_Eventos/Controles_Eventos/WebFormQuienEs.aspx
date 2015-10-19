<%@ Page Language="C#" AutoEventWireup="true" Trace="true" CodeBehind="WebFormQuienEs.aspx.cs" Inherits="Controles_Eventos.WebFormQuienEs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label3" runat="server" Text="Usuario:"></asp:Label>
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="*" ToolTip="campo requerido"></asp:Label>
        <asp:Label ID="lblAlertUsuario" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Contraseña:"></asp:Label>
        <asp:TextBox ID="txtContrasena" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="*" ToolTip="campo requerido"></asp:Label>
        <asp:Label ID="lblAlertContrasena" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Button ID="btnEntrar" runat="server" OnClick="btnEntrar_Click" Text="Entrar" />
        <br />
        <asp:Label ID="lblPermiso" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
