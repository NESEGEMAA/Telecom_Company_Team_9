<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AllServicePlans.aspx.cs" Inherits="Telecom_Company_Team_9.DashBoard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>All Service Plans
    </h1>
    <div>
        <asp:Label ID="ErrorMessageAllServices" runat="server" ForeColor="Red" Text=""></asp:Label>
        <asp:GridView ID="GridViewAlLServices" runat="server" AutoGenerateColumns="true" BorderWidth="1" CssClass="gridview"
            FooterStyle-CssClass="gridview-footer"
            HeaderStyle-CssClass="gridview-header"
            PagerStyle-CssClass="gridview-pager"
            RowStyle-CssClass="gridview-row" />
    </div>
</asp:Content>
