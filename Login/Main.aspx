<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Login.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <br />
        <br />

        <br />
        <asp:Button ID="btnCar" runat="server" OnClick="btnCar_Click" Text="Car" Width="55px" />
        <asp:Button ID="btnFlight" runat="server" Text="Flight" Width="55px" />
        <br />
    </div>
        <asp:Button ID="btnHotel" runat="server" Text="Hotel" Width="55px" />
        <asp:Button ID="btnEvents" runat="server" Text="Events" Width="55px" />
    </form>
</body>
</html>
