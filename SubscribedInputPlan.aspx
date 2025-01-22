<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SubscribedInputPlan.aspx.cs" Inherits="Telecom_Company_Team_9.SubscribedInputPlan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Input Subscribed Plans</h1>
    <div>
        <asp:SqlDataSource 
            ID="SqlDataSource5" 
            OnSelecting="OnMyDataSourceSelecting1" 
            runat="server" 
            ConnectionString="<%$ ConnectionStrings:MyDataBaseConnection %>" 
            SelectCommand="SELECT * FROM dbo.Account_Plan_date(@Subscription_Date, @Plan_id)">
            <SelectParameters>
                <asp:Parameter Name="Subscription_Date" Type="DateTime" />
                <asp:Parameter Name="Plan_id" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />

        <h2>Input a Date:</h2>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>

        <h2>Input the Plan ID:</h2>
        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server"></asp:TextBox>

        <asp:Button ID="Button6" runat="server" CssClass="btn-style" Text="Search" OnClick="Button6_Click" />
        <br />
        <br />

        <asp:GridView ID="GridView5" Visible="False" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource5" CssClass="gridview">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="mobileNo" HeaderText="Mobile Number" SortExpression="mobileNo" />
                <asp:BoundField DataField="balance" HeaderText="Balance" SortExpression="balance" />
                <asp:BoundField DataField="account_type" HeaderText="Account Type" SortExpression="account_type" />
                <asp:BoundField DataField="start_date" HeaderText="Start Date" SortExpression="start_date" />
                <asp:BoundField DataField="status" HeaderText="Status" SortExpression="status" />
                <asp:BoundField DataField="point" HeaderText="Points" SortExpression="point" />
            </Columns>
            <FooterStyle CssClass="gridview-footer" />
            <HeaderStyle CssClass="gridview-header" />
            <PagerStyle CssClass="gridview-pager" />
            <RowStyle CssClass="gridview-row" />
        </asp:GridView>

        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Label"></asp:Label>
        <asp:Label ID="Label4" runat="server" CssClass="label2" Text="Label"></asp:Label>
    </div>
</asp:Content>
