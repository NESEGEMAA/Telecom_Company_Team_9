<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AcceptedPaymentTransaction.aspx.cs" Inherits="Telecom_Company_Team_9.AcceptedPaymentTransaction" %>

<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style>
        /* General Body and HTML Styles */
        html, body {
            margin: 0;
            padding: 0;
            height: 100%; /* Ensure body and html take up the full height */
            font-family: 'Poppins', Arial, sans-serif;
            background-color: #f4f4f4; /* Background color for the page */
            overflow: hidden; /* Prevent unnecessary scrolling */
        }

        /* Page Heading */
        .page-heading {
            font-size: 24px;
            font-weight: bold;
            margin-bottom: 20px;
            color: #333;
            text-align: center;
        }

        /* Input Section */
        .input-section {
            margin-bottom: 20px;
            width: 100%;
            max-width: 400px; /* Similar max-width for inputs */
            display: flex;
            flex-direction: column;
            align-items: center;
            text-align: left;
        }

        .label-text {
            font-size: 14px;
            font-weight: bold;
            margin-bottom: 5px;
            color: #333;
        }

        /* Textbox Styles */
        .input-textbox {
            padding: 10px;
            width: 100%;
            max-width: 350px; /* Matching the max-width as in the login page */
            border: 1px solid #ccc;
            border-radius: 5px;
            font-size: 14px;
            margin-bottom: 15px;
            box-sizing: border-box;
        }

        /* Button Section */
        .button-section {
            margin-bottom: 20px;
            display: flex;
            justify-content: center;
        }

        .action-button {
            background-color: #4CAF50;
            color: white;
            padding: 12px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-size: 16px;
            width: 100%;
            max-width: 350px; /* Matching max-width for buttons */
            transition: background-color 0.3s ease;
        }

        .action-button:hover {
            background-color: #45a049; /* Darker green on hover */
        }

        /* GridView Section */
        .gridview-container {
            margin-top: 30px;
            width: 100%;
            display: flex;
            justify-content: center;
        }

        /* GridView Styling */
        .gridview-footer {
            background-color: #1C5E55;
            font-weight: bold;
            color: white;
        }

        .gridview-header {
            background-color: #4CAF50;
            font-weight: bold;
            color: white;
        }

        .gridview-pager {
            background-color: #666666;
            color: white;
            text-align: center;
        }

        .gridview-row {
            background-color: #E3EAEB;
        }

        .gridview, .gridview th, .gridview td {
            border: none;
            padding: 12px;
            text-align: center;
        }

        /* Message Label */
        .message-label {
            font-size: 16px;
            color: #333;
            font-family: 'Poppins', Arial, sans-serif;
            text-align: center;
        }
    </style>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Heading -->
    <h1>Accepted Payment Transactions</h1>

    <!-- Input Mobile Number Section -->
        <h2>
            Input Mobile Number:
        </h2>
        <asp:TextBox ID="InputNumber" runat="server" CssClass="form-control"></asp:TextBox>

    <!-- Button Section -->
        <asp:Button ID="RetrievePaymentsButton" runat="server" Text="Retrieve Data!" 
                    OnClick="RetrievePaymentsButton_Click" CssClass="btn-style" />
    <br />
    <br />
    <asp:Label ID="PaymentsNumLabel" runat="server"></asp:Label>
    <br />
    <asp:Label ID="SumOfPointsLabel" runat="server" Text=""></asp:Label>
    <br />
    <!-- Message Label -->
        <asp:Label ID="Message" runat="server" Text="" CssStyle="label"></asp:Label>
</asp:Content>
