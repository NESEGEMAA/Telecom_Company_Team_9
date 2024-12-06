<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PhysicalStoresVouchers.aspx.cs" Inherits="Telecom_Company_Team_9.PhysicalStoresVouchers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <h1>
       All Redeemed Vouchers & Stores
   </h1>
    <div>
        <asp:GridView ID="GridView2" runat="server" Visible="False" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="shopID,voucherID" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None" CssClass="gridview">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="shopID" HeaderText="shopID" ReadOnly="True" SortExpression="shopID" />
                <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                <asp:BoundField DataField="working_hours" HeaderText="working_hours" SortExpression="working_hours" />
                <asp:BoundField DataField="voucherID" HeaderText="voucherID" ReadOnly="True" SortExpression="voucherID" />
                <asp:BoundField DataField="value" HeaderText="value" SortExpression="value" />
            </Columns>
            <FooterStyle CssClass="gridview-footer" />
            <HeaderStyle CssClass="gridview-header" />
            <PagerStyle CssClass="gridview-pager" />
            <RowStyle CssClass="gridview-row" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MyDatabaseConnection %>" SelectCommand="SELECT * FROM [PhysicalStoreVouchers]"></asp:SqlDataSource>

    </div>
</asp:Content>
