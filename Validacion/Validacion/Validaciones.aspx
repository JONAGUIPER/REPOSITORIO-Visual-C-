<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validaciones.aspx.cs" Inherits="Validacion.Validaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <script type="text/javascript">
        function validar(oSrc, args) {
            var dato;
            var arrValues;
            arrValues = args.Value.split("/");
            dato = arrValues[0];
            var val1 = dato.split('0')[0];
            var val2 = dato.split(" ")[0];
            //alert(dato != val1);
            //alert(dato != val2);
            if ((dato == val1) && (dato == val2)) {
                //alert(dato);
                args.IsValid = true;
                return;
            } else {
                args.IsValid = false;
                return;
            }

            return false;
        }</script>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Direccion IP (255.255.0.0)"></asp:Label>
            <asp:TextBox ID="txtIP" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtIP" ErrorMessage="Valor no valido" ValidationExpression="\d{3}\.\d{3}\.\d{1}\.\d{1}"></asp:RegularExpressionValidator>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Distinto de 0 y sin espacios"></asp:Label>
            <asp:TextBox ID="txtSin0SinEspacio" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtSin0SinEspacio" ErrorMessage="Ese dato no es valido" OnServerValidate="CustomValidator1_ServerValidate" ClientValidationFunction="validar"></asp:CustomValidator>
            <br />
            <asp:Label ID="lblRespuesta" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="btnEntrar" runat="server" OnClick="btnEntrar_Click" Text="Validar!!!" Width="160px" />

        </div>
    </form>
</body>
</html>
