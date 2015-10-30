<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltasBajasModificaciones.aspx.cs" Inherits="WebAppAltasBajasModificaciones.AltasBajasModificaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblModo" runat="server" Text="Modo Conectado BBDD: "></asp:Label>
            <asp:CheckBox ID="CheckBoxConectado" runat="server" Checked="True" />
            <br />
            <asp:Label ID="lblID" runat="server" Text="Introduce un ID (del 1 al 10):"></asp:Label>
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar fecha" OnClick="btnActualizar_Click" />
            <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
            <asp:GridView ID="GridViewClientes" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
