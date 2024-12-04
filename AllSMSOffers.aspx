<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AllSMSOffers.aspx.cs" Inherits="Telecom_Company_Team_9.AllSMSOffers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <body>
        <div>
            <asp:Label ID="Label1" Visible="false" runat="server" Text="Label"></asp:Label>
            <br />
            Input Your Mobile Number:
                         <br />
            <asp:TextBox ID="TextBox4" Visible="false" runat="server"></asp:TextBox>
            <asp:Button ID="Button9" Visible="false" runat="server" OnClick="Button9_Click" Text="Search" />
            <br />
            <br />

            <asp:GridView ID="GridView6" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
        </div>
</asp:Content>
