<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AllResolvedTickets.aspx.cs" Inherits="Telecom_Company_Team_9.AllResolvedTickets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>All Resolved Tickets
    </h1>
    <div>
        <asp:GridView ID="GridView3" runat="server" Visible="false" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ticketID,mobileNo" DataSourceID="SqlDataSource3" ForeColor="#333333" GridLines="None" CssClass="gridview">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ticketID" HeaderText="ticketID" InsertVisible="False" ReadOnly="True" SortExpression="ticketID" />
                <asp:BoundField DataField="mobileNo" HeaderText="mobileNo" ReadOnly="True" SortExpression="mobileNo" />
                <asp:BoundField DataField="issue_description" HeaderText="issue_description" SortExpression="issue_description" />
                <asp:BoundField DataField="priority_level" HeaderText="priority_level" SortExpression="priority_level" />
                <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
            </Columns>
            <FooterStyle CssClass="gridview-footer" />
            <HeaderStyle CssClass="gridview-header" />
            <PagerStyle CssClass="gridview-pager" />
            <RowStyle CssClass="gridview-row" />
        </asp:GridView>
        <asp:Label ID="Message" runat="server" Text="" CssClass="label2"></asp:Label>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:MyDatabaseConnection %>" SelectCommand="SELECT * FROM [allResolvedTickets]"></asp:SqlDataSource>
    </div>
</asp:Content>
