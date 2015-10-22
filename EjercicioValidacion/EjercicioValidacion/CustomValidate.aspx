<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomValidate.aspx.cs" Inherits="EjercicioValidacion.CustomValidate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Obligatorio"></asp:Label>
            <asp:TextBox ID="txtObligatorio" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="cvObligatorio" runat="server" ErrorMessage="Obligatorio" ControlToValidate="txtObligatorio" OnServerValidate="cvObligatorio_ServerValidate"></asp:CustomValidator>

            <br />
            <asp:Label ID="Label2" runat="server" Text="formato de email:"></asp:Label>
            <asp:TextBox ID="txtFormatoX" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="cvFormatoX" runat="server" ErrorMessage="Formato errado" ControlToValidate="txtFormatoX"></asp:CustomValidator>

            <br />
            <asp:Label ID="Label3" runat="server" Text="Compara con campo anterior"></asp:Label>
            <asp:TextBox ID="txtComparacion" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="cvComparacion" runat="server" ErrorMessage="Comparacion invalida" ControlToValidate="txtComparacion"></asp:CustomValidator>

            <br />
            <asp:Label ID="Label4" runat="server" Text="Valores entre 5 y 20"></asp:Label>
            <asp:TextBox ID="txtEntreValores" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="cvEntreValores" runat="server" ErrorMessage="Valor no Aceptado" ControlToValidate="txtEntreValores"></asp:CustomValidator>

            <br />
            <asp:Label ID="Label5" runat="server" Text="Obligatorio numerico mayor que 0"></asp:Label>
            <asp:TextBox ID="txtNumeroMayor0" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="cvNumerioMayor0" runat="server" ErrorMessage="Valor no Aceptado" ControlToValidate="txtNumeroMayor0"></asp:CustomValidator>

            <br />
            <asp:Button ID="btnValidar" runat="server" Text="Validar!!!" />

        </div>
    </form>
</body>
</html>
