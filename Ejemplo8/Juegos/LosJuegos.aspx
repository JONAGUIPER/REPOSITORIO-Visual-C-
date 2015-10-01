<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LosJuegos.aspx.cs" Inherits="Juegos.LosJuegos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="txtDado1" runat="server" Font-Bold="True" Font-Size="XX-Large" Height="50px" Width="80px"></asp:TextBox>
            <asp:TextBox ID="txtDado2" runat="server" Font-Bold="True" Font-Size="XX-Large" Height="50px" Width="80px"></asp:TextBox>
            <br />
            <asp:Button ID="btnJugar" runat="server" Text="Jugar!!!" Width="174px" OnClick="JugarAleatorios" />
            <br />
            <p>
                <asp:Label ID="lblPrimo" runat="server" Text="Introduzca para comprobar numero primo: "></asp:Label>
                <asp:TextBox ID="txtPrimo" runat="server"></asp:TextBox>
                <asp:Label ID="lblRespuesta" runat="server" Text=" "></asp:Label>
                <br />
                <asp:Button ID="btnPrimo" runat="server" Text="Verificar" OnClick="JugarNumeroPrimo" />



            </p>
            <p>
                <asp:Label ID="Label2" runat="server" Text="introduzaca 2 numeros con su operacion para calcular resultado"></asp:Label>
                <br />
                <asp:TextBox ID="txtNumero1" runat="server"></asp:TextBox>
                <asp:TextBox ID="txtOperacion" runat="server" Width="23px"></asp:TextBox>
                <asp:TextBox ID="txtNumero2" runat="server"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" Text="="></asp:Label>
                <asp:Label ID="lblResultadoOperacion" runat="server"></asp:Label>
                <asp:Button ID="btnCalcular" runat="server" Text="Verificar" OnClick="CalcularConOperacion" />

            </p>
            <br />
            <br />
            <br />
            <br />
            <p>
                <asp:Button Text="Media" ID="btnMedia" runat="server" OnClick="CalcularMedia"/>
                <asp:TextBox ID="txtMedia" runat="server"  />
                <asp:Label Text="Datos" ID="lblDatos" runat="server" />
            </p>

            <p>
                <asp:Button Text="Codificar" ID="btnCodificar" runat="server" OnClick="CodificarTexto"/>
                <asp:TextBox ID="txtCodificar" runat="server"  />
                <asp:Label Text=" " ID="lblTextoCodificado" runat="server" />
            </p>
        </div>


    </form>
</body>
</html>
