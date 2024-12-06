<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="RemoveAllBenefits.aspx.cs" Inherits="Telecom_Company_Team_9.RemoveAllBenefits" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        Remove Input Account Benefits
    </h1>
    <div>
        <br />
        Input your Mobile Number:
            <br />
        <asp:TextBox Visible="false" ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        Input the Plan ID:
            <br />
        <asp:TextBox Visible="false" ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button Visible="false" ID="Button7" runat="server" Text="Delete" OnClick="Button7_Click" />
    </div>
</asp:Content>

