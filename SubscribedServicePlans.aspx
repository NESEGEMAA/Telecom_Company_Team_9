﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SubscribedServicePlans.aspx.cs" Inherits="Telecom_Company_Team_9.SubscribedServicePlans" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:GridView ID="GridView4" Visible="False" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource4" CssClass="gridview">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="mobileNo" HeaderText="mobileNo" SortExpression="mobileNo" />
                <asp:BoundField DataField="pass" HeaderText="pass" SortExpression="pass" />
                <asp:BoundField DataField="balance" HeaderText="balance" SortExpression="balance" />
                <asp:BoundField DataField="account_type" HeaderText="account_type" SortExpression="account_type" />
                <asp:BoundField DataField="start_date" HeaderText="start_date" SortExpression="start_date" />
                <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
                <asp:BoundField DataField="points" HeaderText="points" SortExpression="points" />
                <asp:BoundField DataField="nationalID" HeaderText="nationalID" SortExpression="nationalID" />
                <asp:BoundField DataField="planID" HeaderText="planID" InsertVisible="False" ReadOnly="True" SortExpression="planID" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                <asp:BoundField DataField="SMS_offered" HeaderText="SMS_offered" SortExpression="SMS_offered" />
                <asp:BoundField DataField="minutes_offered" HeaderText="minutes_offered" SortExpression="minutes_offered" />
                <asp:BoundField DataField="data_offered" HeaderText="data_offered" SortExpression="data_offered" />
                <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
            </Columns>
            <FooterStyle CssClass="gridview-footer" />
            <HeaderStyle CssClass="gridview-header" />
            <PagerStyle CssClass="gridview-pager" />
            <RowStyle CssClass="gridview-row" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:MyDatabaseConnection %>" SelectCommand="Account_Plan" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    </div>
</asp:Content>