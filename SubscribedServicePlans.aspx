<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SubscribedServicePlans.aspx.cs" Inherits="Telecom_Company_Team_9.SubscribedServicePlans" %>

<asp:Content runat="server" ID="Content2" ContentPlaceHolderID="HeadContent">
    <style>
        /* Make the table font size smaller (50% reduction) */
        .gridview {
            font-size: 5px !important; /* Reduce font size by half */
            width: 100% !important; /* Ensure it takes up full width of the container */
            max-width: 100%; /* Ensure it doesn't overflow the container */
        }

        .gridview th, .gridview td {
            padding: 4px !important; /* Reduce padding by half to make the table more compact */
            text-align: left;
        }

        /* Style for the GridView container (wrapper) */
        .gridview-wrapper {
            width: 100%;
            overflow-x: auto; /* Enable horizontal scrolling if needed */
            overflow-y: auto; /* Enable vertical scrolling */
            margin: 0 auto; /* Center the table wrapper */
            max-width: 100%; /* Ensure it doesn't exceed the screen width */
            box-sizing: border-box;
        }

        /* Header Styles */
        .gridview-header {
            background-color: #4CAF50;
            color: white;
            font-weight: bold;
            text-transform: uppercase;
            font-size: 6px !important; /* Smaller header font size */
            padding: 5px 8px;
        }

        /* Row Styles */
        .gridview-row {
            background-color: #f9f9f9;
            border-bottom: 1px solid #ddd;
        }

        .gridview tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        .gridview tr:hover:not(.gridview-header) {
            background-color: #f1f1f1;
        }

        /* Adjust the footer and pager styles */
        .gridview-footer, .gridview-pager {
            background-color: #1C5E55;
            color: white;
            font-weight: bold;
            padding: 5px 8px;
            text-align: center;
        }

        /* Mobile Responsiveness */
        @media (max-width: 768px) {
            .gridview-wrapper {
                max-height: 300px; /* Smaller max height on mobile */
            }

            .gridview {
                font-size: 5px; /* Keep font smaller on mobile */
            }

            .gridview th, .gridview td {
                padding: 3px 5px; /* Even smaller padding on mobile */
            }

            .gridview-header, .gridview-footer, .gridview-pager {
                padding: 4px 6px; /* Less padding on mobile */
            }
        }
    </style>
</asp:Content>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Heading -->
    <h1 style="font-family: 'Montserrat', Arial, sans-serif; font-weight: 600;">All Subscribed Service Plans</h1>

    <!-- GridView container with borders -->
    <div class="gridview-wrapper">
        <asp:GridView ID="GridView4" Visible="True" runat="server" AutoGenerateColumns="False" 
            DataSourceID="SqlDataSource4" CssClass="gridview" OnRowDataBound="GridView4_RowDataBound">
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
    </div>

    <!-- Message Display -->
    <p>
        <asp:Label ID="Message" runat="server" Text="" CssClass="label2"></asp:Label>
    </p>

    <!-- SqlDataSource for Data Binding -->
    <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
        ConnectionString="<%$ ConnectionStrings:MyDatabaseConnection %>" 
        SelectCommand="Account_Plan" SelectCommandType="StoredProcedure">
    </asp:SqlDataSource>
</asp:Content>
