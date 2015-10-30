<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FillOrCancel.aspx.cs" Inherits="ADOAplication.FillOrCancel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Orden ID:   "></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
        <asp:Button ID="btnFindByOrderID" runat="server" OnClick="btnFindByOrderID_Click" Text="Buscar Orden" />
        <br />
        <br />
        <asp:Label ID="lblEstado" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Si llena un pedido , especifique la fecha llenado"></asp:Label>
        <asp:TextBox ID="dtpFillDate" runat="server"></asp:TextBox>
        <br />
        <asp:GridView ID="dgvCustomerOrders" runat="server">
        </asp:GridView>
        <br />
        <asp:Button ID="btnCancelOrder" runat="server" Text="Cancelar Orden" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFillOrder" runat="server" OnClick="btnFillOrder_Click" Text="Llenar Orden" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFinishUpdates" runat="server" PostBackUrl="~/Navegation.aspx" Text="Finalizar" />
    
    </div>
    </form>
</body>
</html>
