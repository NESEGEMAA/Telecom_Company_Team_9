<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PhysicalStoresVouchers.aspx.cs" Inherits="Telecom_Company_Team_9.PhysicalStoresVouchers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:GridView ID="GridView2" runat="server" Visible="False" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="shopID,voucherID" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="shopID" HeaderText="shopID" ReadOnly="True" SortExpression="shopID" />
                <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                <asp:BoundField DataField="working_hours" HeaderText="working_hours" SortExpression="working_hours" />
                <asp:BoundField DataField="voucherID" HeaderText="voucherID" ReadOnly="True" SortExpression="voucherID" />
                <asp:BoundField DataField="value" HeaderText="value" SortExpression="value" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MyDatabaseConnection %>" SelectCommand="SELECT * FROM [PhysicalStoreVouchers]"></asp:SqlDataSource>

    </div>
</asp:Content>
