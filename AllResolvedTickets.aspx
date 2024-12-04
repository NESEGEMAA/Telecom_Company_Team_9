<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AllResolvedTickets.aspx.cs" Inherits="Telecom_Company_Team_9.AllResolvedTickets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:GridView ID="GridView3" runat="server" Visible="false" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ticketID,mobileNo" DataSourceID="SqlDataSource3" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ticketID" HeaderText="ticketID" InsertVisible="False" ReadOnly="True" SortExpression="ticketID" />
                <asp:BoundField DataField="mobileNo" HeaderText="mobileNo" ReadOnly="True" SortExpression="mobileNo" />
                <asp:BoundField DataField="issue_description" HeaderText="issue_description" SortExpression="issue_description" />
                <asp:BoundField DataField="priority_level" HeaderText="priority_level" SortExpression="priority_level" />
                <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
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
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:MyDatabaseConnection %>" SelectCommand="SELECT * FROM [allResolvedTickets]"></asp:SqlDataSource>
    </div>
</asp:Content>
