<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Top10Payments.aspx.cs" Inherits="Telecom_Company_Team_9.Top10Payments" %>


            <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <!-- Part 6-->
            <h2>Check Top 10 Successful Payments on the account</h2><br />
            Mobile Number:<br />
            <asp:TextBox ID="mob" runat="server"></asp:TextBox>
            <br />
            <br />
        
             <asp:Button ID="ButtonPayment" runat="server" Text="View Payments" OnClick="PaymentView" />
            <asp:GridView ID="GridViewPayment" runat="server" CssClass="gridview">
                <FooterStyle CssClass="gridview-footer" />
                <HeaderStyle CssClass="gridview-header" />
                <PagerStyle CssClass="gridview-pager" />
                <RowStyle CssClass="gridview-row" />
            </asp:GridView>
            <br />
            <asp:Label ID="LabelPayment" runat="server" ></asp:Label>
            <br />
            <br />
            <br />
            <br />
        
            </asp:Content>
