<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="HighestVoucherID.aspx.cs" Inherits="Telecom_Company_Team_9.HighestVoucherID" %>
            

            <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <!-- Part 3-->
            <h2>Checking Highest Voucher ID</h2>

            <br />
            Mobile Number:<br />
             <asp:TextBox ID="mobi" runat="server"></asp:TextBox>
             <br />
            <br />


            <asp:Button ID="ButtonVocuher" runat="server" Text="Check" OnClick="ViewVoucher" />
            <br />
            <br />

            <asp:Label ID="LabelVoucher" runat="server" Visible="false" ></asp:Label>
            <br />
            <br />

            </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FooterContent" Runat="Server">
    <p style="color: red">The output displayed on loading the page is the output for the current logged in customer; However, the ability to fetch other's data is kept for means of testing</p>
</asp:Content>
