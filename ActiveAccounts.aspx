<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ActiveAccounts.aspx.cs" Inherits="Telecom_Company_Team_9.ActiveAccounts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        View All Active Accounts
    </h1>
    <div>
        <div class="gridview-wrapper">
            <asp:GridView ID="GridView1" runat="server" 
                          DataSourceID="SqlDataSource1" 
                          AutoGenerateColumns="False" 
                          Visible="True" 
                          DataKeyNames="nationalID,mobileNo" 
                          CssClass="gridview">
                <Columns>
                    <asp:BoundField DataField="nationalID" HeaderText="National ID" SortExpression="nationalID" />
                    <asp:BoundField DataField="first_name" HeaderText="First Name" SortExpression="first_name" />
                    <asp:BoundField DataField="last_name" HeaderText="Last Name" SortExpression="last_name" />
                    <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                    <asp:BoundField DataField="address" HeaderText="Address" SortExpression="address" />
                    <asp:BoundField DataField="date_of_birth" HeaderText="Date of Birth" SortExpression="date_of_birth" />
                    <asp:BoundField DataField="mobileNo" HeaderText="Mobile No" SortExpression="mobileNo" />
                    <asp:BoundField DataField="account_type" HeaderText="Account Type" SortExpression="account_type" />
                    <asp:BoundField DataField="status" HeaderText="Status" SortExpression="status" />
                    <asp:BoundField DataField="start_date" HeaderText="Start Date" SortExpression="start_date" />
                    <asp:BoundField DataField="balance" HeaderText="Balance" SortExpression="balance" />
                    <asp:BoundField DataField="points" HeaderText="Points" SortExpression="points" />
                </Columns>

                <FooterStyle CssClass="gridview-footer" />
                <HeaderStyle CssClass="gridview-header" />
                <PagerStyle CssClass="gridview-pager" />
                <RowStyle CssClass="gridview-row" />
                <AlternatingRowStyle BackColor="White" />
            </asp:GridView>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                          ConnectionString="<%$ ConnectionStrings:MyDatabaseConnection %>" 
                          SelectCommand="SELECT * FROM [allCustomerAccounts]">
        </asp:SqlDataSource>

    </div>
</asp:Content>
