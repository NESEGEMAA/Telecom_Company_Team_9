<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ActiveAccounts.aspx.cs" Inherits="Telecom_Company_Team_9.ActiveAccounts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" Visible="False" DataKeyNames="nationalID,mobileNo" CssClass="gridview">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="nationalID" HeaderText="nationalID" ReadOnly="True" SortExpression="nationalID" />
                <asp:BoundField DataField="first_name" HeaderText="first_name" SortExpression="first_name" />
                <asp:BoundField DataField="last_name" HeaderText="last_name" SortExpression="last_name" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                <asp:BoundField DataField="date_of_birth" HeaderText="date_of_birth" SortExpression="date_of_birth" />
                <asp:BoundField DataField="mobileNo" HeaderText="mobileNo" ReadOnly="True" SortExpression="mobileNo" />
                <asp:BoundField DataField="account_type" HeaderText="account_type" SortExpression="account_type" />
                <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
                <asp:BoundField DataField="start_date" HeaderText="start_date" SortExpression="start_date" />
                <asp:BoundField DataField="balance" HeaderText="balance" SortExpression="balance" />
                <asp:BoundField DataField="points" HeaderText="points" SortExpression="points" />
            </Columns>
                <FooterStyle CssClass="gridview-footer" />
                <HeaderStyle CssClass="gridview-header" />
                <PagerStyle CssClass="gridview-pager" />
                <RowStyle CssClass="gridview-row" />
        </asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MyDatabaseConnection %>" SelectCommand="SELECT * FROM [allCustomerAccounts]"></asp:SqlDataSource>
    </div>
</asp:Content>

