﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadenaBusqueda.aspx.cs" Inherits="LoginADO.CadenaBusqueda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtCadena" runat="server"></asp:TextBox>
        <asp:Button ID="btnEnviarXURL" runat="server" Text="Enviar Query" OnClick="btnEnviarXURL_Click" />
    </div>
    </form>
</body>
</html>
