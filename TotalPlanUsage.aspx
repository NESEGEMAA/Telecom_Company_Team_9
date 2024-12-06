<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="TotalPlanUsage.aspx.cs" Inherits="Telecom_Company_Team_9.TotalUsage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Input Account Total Plan Usage
        </h1>
        <br />
        <h2>
            Input a Date:
        </h2>
            <div class="calendar-container">
                <asp:Calendar ID="Calendar2" runat="server" CssClass="calendar-table" />
            </div>
        <h2>
            Input your Mobile Number:
        </h2>
        <asp:TextBox ID="TextBox5" Visible="false" CssClass="form-control" runat="server"></asp:TextBox>
        <asp:Button ID="Button10" Visible="false" runat="server" CssClass="btn-style" Text="Search" OnClick="Button10_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView7" runat="server" CssClass="gridview">
            <FooterStyle CssClass="gridview-footer" />
            <HeaderStyle CssClass="gridview-header" />
            <PagerStyle CssClass="gridview-pager" />
            <RowStyle CssClass="gridview-row" />
        </asp:GridView>
        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Label"></asp:Label>
    </div>
</asp:Content>
