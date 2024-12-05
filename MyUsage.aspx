<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="MyUsage.aspx.cs" Inherits="Telecom_Company_Team_9.MyUsage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Your plan usage</h1>
        <asp:Label ID="MyUsage" runat="server" Text="Mobile no: "></asp:Label>
        <asp:TextBox ID="Mobileno" runat="server"></asp:TextBox>
        <asp:Button ID="EnteredNumber" runat="server" Text="Enter" OnClick ="MyUsageTable" />
        <asp:GridView ID="GridViewMyUsage" runat="server" AutoGenerateColumns="true" CssClass="gridview">
            <FooterStyle CssClass="gridview-footer" />
            <HeaderStyle CssClass="gridview-header" />
            <PagerStyle CssClass="gridview-pager" />
            <RowStyle CssClass="gridview-row" />
        </asp:GridView>
        <asp:Label ID="ErrorMessageMyUsage" runat="server" ForeColor="Red" Text=""></asp:Label>
    </div>
</asp:Content>