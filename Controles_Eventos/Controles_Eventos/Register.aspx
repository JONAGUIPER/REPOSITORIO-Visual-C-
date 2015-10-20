<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Controles_Eventos.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/jquery-2.1.4.min.js"></script>
    <script src="Scripts/jquery.validate.unobtrusive.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" ErrorMessage="Debe introducir su nombre"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Apellido"></asp:Label>
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" BorderStyle="None" ControlToValidate="txtApellido" ErrorMessage="Debe introducir su Apellido"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Edad:"></asp:Label>
        <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtEdad" ErrorMessage="introduzca su edad (0-90)" MaximumValue="90" MinimumValue="0"></asp:RangeValidator>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Contraseña"></asp:Label>
        <asp:TextBox ID="txtContrasena" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtContrasena" ErrorMessage="Debe Introducir Ccntraseña"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Repetir Contraseña"></asp:Label>
        <asp:TextBox ID="txtRepetirContrasena" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtRepetirContrasena" ErrorMessage="No coincide contraseñas" ControlToValidate="txtContrasena"></asp:CompareValidator>
        <br />
        <br />
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
    
    </div>
    </form>
</body>
</html>
