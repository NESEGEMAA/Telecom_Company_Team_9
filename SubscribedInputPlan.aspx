<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SubscribedInputPlan.aspx.cs" Inherits="Telecom_Company_Team_9.SubscribedInputPlan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Input Subscribed Plans
    </h1>
    <div>
        <asp:SqlDataSource ID="SqlDataSource5" OnSelecting="OnMyDataSourceSelecting1" runat="server" ConnectionString="<%$ ConnectionStrings:MyDataBaseConnection %>" SelectCommand="SELECT Account_Plan_date_1.* FROM dbo.Account_Plan_date(@date, @plan) AS Account_Plan_date_1">
            <SelectParameters>
                <asp:Parameter Type="DateTime" Name="date" />
                <asp:Parameter Type="Int32" Name="plan" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />


        <h2>Input a Date:
        </h2>
        <asp:Calendar ID="Calendar1" Visible="False" runat="server" SelectedDate="12/04/2024 17:05:51"></asp:Calendar>
        <h2>Input the Plan ID:
        </h2>
        <asp:TextBox Visible="false" CssClass="form-control" ID="TextBox1" runat="server"></asp:TextBox>

        <asp:Button Visible="false" ID="Button6" runat="server" CssClass="btn-style" Text="Search" OnClick="Button6_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView5" Visible="False" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource5" CssClass="gridview">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="mobileNo" HeaderText="mobileNo" SortExpression="mobileNo" />
                <asp:BoundField DataField="planID" HeaderText="planID" SortExpression="planID" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
            </Columns>
            <FooterStyle CssClass="gridview-footer" />
            <HeaderStyle CssClass="gridview-header" />
            <PagerStyle CssClass="gridview-pager" />
            <RowStyle CssClass="gridview-row" />
        </asp:GridView>
        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Label"></asp:Label>
    </div>
</asp:Content>
