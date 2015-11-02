<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="LoginADO.Register" %>

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
            <asp:Label ID="l" runat="server" Text="REGISTRO DE USUARIOS"></asp:Label>
        </h1>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Fecha de Nacimiento:"></asp:Label>
        <asp:TextBox ID="txtFechaNacimiento" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Usuario:  "></asp:Label>
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Password:  "></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" PostBackUrl="~/Login.aspx" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
    
        <br />
        <br />
        <asp:Label ID="lblEstado" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
