﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SubscribedInputPlan.aspx.cs" Inherits="Telecom_Company_Team_9.SubscribedInputPlan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:SqlDataSource ID="SqlDataSource5" OnSelecting="OnMyDataSourceSelecting1" runat="server" ConnectionString="<%$ ConnectionStrings:MyDataBaseConnection %>" SelectCommand="SELECT Account_Plan_date_1.* FROM dbo.Account_Plan_date(@date, @plan) AS Account_Plan_date_1">
        <SelectParameters>
            <asp:Parameter Type="DateTime" Name="date" />
            <asp:Parameter Type="Int32" Name="plan" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />



    <asp:Label ID="Label1" runat="server" Text="Input a Date:"></asp:Label>
    <div class="calendar-container">
        <asp:Calendar ID="Calendar1" runat="server" CssClass="calendar-table" />
    </div>

    <br />

    <asp:Label ID="Label2" runat="server" Text="Input the Plan ID:"></asp:Label>
    <br />

    <asp:TextBox Visible="false" ID="TextBox1" runat="server"></asp:TextBox>

    <asp:Button Visible="false" ID="Button6" runat="server" Text="Search" OnClick="Button6_Click" />
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
    <br />
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
</asp:Content>
