<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="TotalPlanUsage.aspx.cs" Inherits="Telecom_Company_Team_9.TotalUsage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>
            Input Account Total Plan Usage
        </h1>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        Input a date:
            <div class="calendar-container">
                <asp:Calendar ID="Calendar2" runat="server" CssClass="calendar-table" />
            </div>
        <br />
        Input your Mobile Number:
            <br />
        <asp:TextBox ID="TextBox5" Visible="false" runat="server"></asp:TextBox>
        <asp:Button ID="Button10" Visible="false" runat="server" Text="Search" OnClick="Button10_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView7" runat="server" CssClass="gridview">
            <FooterStyle CssClass="gridview-footer" />
            <HeaderStyle CssClass="gridview-header" />
            <PagerStyle CssClass="gridview-pager" />
            <RowStyle CssClass="gridview-row" />
        </asp:GridView>
    </div>
</asp:Content>
