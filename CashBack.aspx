<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CashBack.aspx.cs" Inherits="Telecom_Company_Team_9.CashBack" %>

<asp:Content runat="server" ID="Content2" ContentPlaceHolderID="HeadContent">
    <!-- Page-specific CSS -->
    <style>
        /* Apply borders to the Cashback GridView */
        .gridview-with-borders {
            border: 1px solid #ddd;
            border-collapse: collapse;
        }

        .gridview-with-borders th, .gridview-with-borders td {
            border: 1px solid #ddd; /* Add border to each cell */
            padding: 8px;
            text-align: center;
        }

        .gridview-with-borders th {
            background-color: #4CAF50;
            color: white;
            font-weight: bold;
        }

        .gridview-with-borders tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        .gridview-with-borders tr:hover {
            background-color: #ddd;
        }
    </style>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Heading -->
    <h1 style="font-family: 'Montserrat', Arial, sans-serif; font-weight: 600;">Cashback</h1>

    <!-- GridView container with borders -->
    <div class="gridview-container">
        <asp:GridView ID="CashbackView" runat="server" CssClass="gridview-with-borders">
            <FooterStyle CssClass="gridview-footer" />
            <HeaderStyle CssClass="gridview-header" />
            <PagerStyle CssClass="gridview-pager" />
            <RowStyle CssClass="gridview-row" />
        </asp:GridView>
    </div>

    <!-- Message Display -->
    <p>
        <asp:Label ID="Message" runat="server" Text="" CssClass="message-label"></asp:Label>
    </p>
</asp:Content>
