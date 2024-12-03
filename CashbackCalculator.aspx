<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CashbackCalculator.aspx.cs" Inherits="Telecom_Company_Team_9.CashbackCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Receive your Cashback!</h1>
        <section>
            <asp:Label ID="MobileNumberLabel" runat="server" Text="Input your mobile number:"></asp:Label>
        </section>
        <section>
            <asp:TextBox ID="InputMobileNumber" runat="server"></asp:TextBox>
        </section>
        <section>
            <asp:Label ID="PaymentIDLabel" runat="server" Text="Input the payment ID:"></asp:Label>
        </section>
        <section>
            <asp:TextBox ID="InputPaymentID" runat="server"></asp:TextBox>
        </section>
        <section>
            <asp:Label ID="BenefitIDLabel" runat="server" Text="Input Benefit ID:"></asp:Label>
        </section>
        <section>
            <asp:TextBox ID="InputBenefitID" runat="server"></asp:TextBox>
        </section>
        <section>
            <asp:Label ID="Message" runat="server" Text=""></asp:Label>
        </section>
        <asp:Button ID="Calculatebutton" runat="server" Text="Calculate!" OnClick="Calculate" />
    </form>
</body>
</html>
