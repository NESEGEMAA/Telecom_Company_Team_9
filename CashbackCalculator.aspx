<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CashbackCalculator.aspx.cs" Inherits="Telecom_Company_Team_9.CashbackCalculator" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
</asp:Content>
