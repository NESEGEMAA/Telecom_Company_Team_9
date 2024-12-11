<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="MyUsage.aspx.cs" Inherits="Telecom_Company_Team_9.MyUsage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Your Plan Usage</h1>
        <h2>Mobile no:</h2>
        <asp:TextBox ID="Mobileno" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:Button ID="EnteredNumber" runat="server" Text="Enter" OnClick="MyUsageTable" CssClass="btn-style" />
        <asp:GridView ID="GridViewMyUsage" runat="server" AutoGenerateColumns="true" CssClass="gridview">
            <FooterStyle CssClass="gridview-footer" />
            <HeaderStyle CssClass="gridview-header" />
            <PagerStyle CssClass="gridview-pager" />
            <RowStyle CssClass="gridview-row" />
        </asp:GridView>
        <asp:Label ID="ErrorMessageMyUsage" runat="server" Text="" CssClass="label"></asp:Label>
    </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FooterContent" runat="Server">
    <p style="color: red">The output displayed on loading the page is the output for the current logged in customer; However, the ability to fetch other's data is kept for means of testing</p>
</asp:Content>
