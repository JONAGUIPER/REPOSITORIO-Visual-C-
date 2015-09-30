<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TiposMetodos.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="ldlNombre" runat="server" Text="Nombre" Width="150px"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblApellido1" runat="server" Text="Apellido1" Width="150px"></asp:Label>
        <asp:TextBox ID="txtApellido1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblApellido2" runat="server" Text="Apellido2" Width="150px"></asp:Label>
        <asp:TextBox ID="txtApellido2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblEdad" runat="server" Text="Edad" Width="150px"></asp:Label>
        <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSueldo" runat="server" Text="Sueldo" Width="150px"></asp:Label>
        <asp:TextBox ID="txtSueldo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblFechaNacimiento" runat="server" Text="Fecha de Nacimiento" Width="150px"></asp:Label>
        <asp:TextBox ID="txtFechadeNacimiento" runat="server"></asp:TextBox>

    </form>
</body>
</html>
