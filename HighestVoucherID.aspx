<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="HighestVoucherID.aspx.cs" Inherits="Telecom_Company_Team_9.HighestVoucherID" %>
            

            <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <!-- Part 3-->
            <h1>Checking Highest Voucher ID</h1>

            <h2>Mobile Number:</h2>
            <asp:TextBox ID="mobi" runat="server"></asp:TextBox>
            <br />
            <br />


            <asp:Button ID="ButtonVocuher" runat="server" Text="Check" OnClick="ViewVoucher" CssClass="btn-style"/>
            <br />
            <br />

            <asp:Label ID="LabelVoucher" runat="server" Visible="false" CssClass="label"></asp:Label>
            <br />
            <br />

            </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FooterContent" Runat="Server">
    <p style="color: red">The output displayed on loading the page is the output for the current logged in customer; However, the ability to fetch other's data is kept for means of testing</p>
</asp:Content>
