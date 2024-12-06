<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="MyConsumption.aspx.cs" Inherits="Telecom_Company_Team_9.MyConsumption" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Everyone's Plan Consumption For Some Reason .,.</h1>
    <h2>Select the plan name here:</h2>
    <asp:DropDownList ID="PlanList" runat="server">
        <asp:ListItem Text="Basic" Value="Basic"></asp:ListItem>
        <asp:ListItem Text="Premium" Value="Premium"></asp:ListItem>
        <asp:ListItem Text="Ultimate" Value="Ultimate"></asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <h2>Choose the start date</h2>
    <div class="calendar-container">
        <asp:Calendar ID="Calendar1" runat="server" CssClass="calendar-table" />
    </div>
    <br />
    <h2>Choose the end date</h2>
    <div class="calendar-container">
        <asp:Calendar ID="Calendar2" runat="server" CssClass="calendar-table" />
    </div>
    <br />
    <asp:Button ID="ButtonMC" runat="server" Text="Submit" OnClick="Compute" CssClass="btn-style" />
    <asp:GridView ID="GridViewMyConsumption" runat="server" CssClass="gridview">
        <footerstyle cssclass="gridview-footer" />
        <headerstyle cssclass="gridview-header" />
        <pagerstyle cssclass="gridview-pager" />
        <rowstyle cssclass="gridview-row" />
    </asp:GridView>
    <asp:Label ID="ErrorMessageMyConsumption" runat="server" Text="" CssClass="label"></asp:Label>
</asp:Content>

