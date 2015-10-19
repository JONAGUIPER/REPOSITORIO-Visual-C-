<%@ Page Language="C#" Trace="true" AutoEventWireup="true" CodeBehind="WebFormEventos.aspx.cs" Inherits="Controles_Eventos.WebFormEventos" EnableViewState="False" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" enableviewstate="False" runat="server">
        <div>
            <asp:Label ID="lblMyApp" runat="server" Text="MyApp"></asp:Label>
            <asp:TextBox ID="txtNombre" EnableViewState="false" Text="Introduce tu nombre aqui" ForeColor="Gray" runat="server" Width="128px" />
            <br />
            <asp:Button ID="btnHola" Text="Hola" runat="server" OnClick="btnHola_Click" />
            <br />
            <asp:CheckBox ID="ChBoxOpcion1" Checked Text="Opcion1" runat="server" />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="1">EL UNO</asp:ListItem>
                <asp:ListItem Selected="True" Value="2">EL DOS</asp:ListItem>
                <asp:ListItem Value="3">EL TRES</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:HyperLink ID="HyperLinkMdsn" runat="server" NavigateUrl="http://www.ASP.NET" Text="Pagina ASP.NET"></asp:HyperLink>
            <asp:Image ImageUrl="~/images/cuba5.jpg" runat="server" />
            <br />
            <asp:RadioButton ID="RButton1" Checked="true" runat="server" GroupName="RGroup" Text="Opcion 1" />
            <br />
            <asp:RadioButton ID="RButton2" runat="server" GroupName="RGroup" Text="Opcion 2" />
            <br />
            <asp:RadioButton ID="RButton3" runat="server" GroupName="RGroup" Text="Opcion 3" />
            <br />
        </div>



    </form>
    <p>
        &nbsp;
    </p>
</body>
</html>
