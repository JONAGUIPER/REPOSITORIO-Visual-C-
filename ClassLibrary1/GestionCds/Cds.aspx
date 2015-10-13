<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cds.aspx.cs" Inherits="GestionCds.Cds" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="style/estilos.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Interprete" HeaderText="Interprete" ReadOnly="True" SortExpression="Interprete" />
                <asp:BoundField DataField="Titulo" HeaderText="Titulo" ReadOnly="True" SortExpression="Titulo" />
                <asp:BoundField DataField="Genero" HeaderText="Genero" ReadOnly="True" SortExpression="Genero" />
                <asp:BoundField DataField="FechaPublicacion" HeaderText="FechaPublicacion" ReadOnly="True" SortExpression="FechaPublicacion" />
                <asp:BoundField DataField="Discografica" HeaderText="Discografica" ReadOnly="True" SortExpression="Discografica" />
                <asp:BoundField DataField="IdCd" HeaderText="IdCd" ReadOnly="True" SortExpression="IdCd" />
                <asp:BoundField DataField="Ubicacion" HeaderText="Ubicacion" ReadOnly="True" SortExpression="Ubicacion" />
                <asp:ImageField DataImageUrlField="Caratula" HeaderText="Caratula">
                </asp:ImageField>
            </Columns>
        </asp:GridView>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="Cd.FactoriaCdMusica" EntityTypeName="" Select="new (Interprete, Titulo, Genero, FechaPublicacion, Discografica, Caratula, IdCd, Canciones, Ubicacion)" TableName="Cds">
        </asp:LinqDataSource>
    </div>
    </form>
</body>
</html>
