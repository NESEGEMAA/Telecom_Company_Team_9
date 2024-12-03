<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RedeemVoucher.aspx.cs" Inherits="Telecom_Company_Team_9.RedeemVoucher" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Redeem your Voucher here:</h1>
    <section>
        <asp:Label ID="mobileNumberLabel" runat="server" Text="Input your Mobile Number"></asp:Label>
    </section>
    <section>
        <asp:TextBox ID="InputMobileNumber" runat="server"></asp:TextBox>
    </section>
    <section>
        <asp:Label ID="voucherIDLabel" runat="server" Text="Input the voucher ID you want to redeem"></asp:Label>
    </section>
    <section>
        <asp:TextBox ID="InputVoucherID" runat="server"></asp:TextBox>
    </section>
    <section>
        <asp:Label ID="Message" runat="server" Text=""></asp:Label>
    </section>
    <asp:Button ID="redeemButton" runat="server" Text="Redeem!" OnClick="Redeem" />
</form>
</body>
</html>
