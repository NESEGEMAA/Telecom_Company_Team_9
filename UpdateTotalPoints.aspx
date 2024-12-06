<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UpdateTotalPoints.aspx.cs" Inherits="Telecom_Company_Team_9.UpdateTotalPoints" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Heading -->
    <h1>Update Total Earned Points</h1>

    <!-- Input Mobile Number Section -->
    <h2>Input Mobile Number:
    </h2>
    <asp:TextBox ID="InputNumber" runat="server" CssClass="form-control"></asp:TextBox>
    <!-- Button Section -->
    <asp:Button ID="UpdateTotalPointsButton" runat="server" Text="Update Points"
        OnClick="UpdateTotalPointsButton_Click" CssClass="btn-style" />

    <!-- GridView Section -->
    <div class="gridview-container">
        <asp:GridView ID="UpdateTotalpPointsView" runat="server" CssClass="gridview">
            <FooterStyle CssClass="gridview-footer" />
            <HeaderStyle CssClass="gridview-header" />
            <PagerStyle CssClass="gridview-pager" />
            <RowStyle CssClass="gridview-row" />
        </asp:GridView>
    </div>

    <!-- Message Label -->
    <p>
        <asp:Label ID="Message" runat="server" Text="" CssClass="label"></asp:Label>
        <asp:Label ID="Message2" runat="server" Text="" CssClass="label2"></asp:Label>
    </p>
</asp:Content>
