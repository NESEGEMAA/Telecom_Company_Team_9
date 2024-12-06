<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="RedeemVoucher.aspx.cs" Inherits="Telecom_Company_Team_9.RedeemVoucher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
        <asp:TextBox ID="InputVoucherID" runat="server" CssClass="form-control"></asp:TextBox>
    </section>
    <section>
        <asp:Label ID="Message" runat="server" Text=""></asp:Label>
    </section>
    <asp:Button ID="redeemButton" runat="server" Text="Redeem!" OnClick="Redeem" />
</asp:Content>
