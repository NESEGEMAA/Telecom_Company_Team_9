<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="RemoveAllBenefits.aspx.cs" Inherits="Telecom_Company_Team_9.RemoveAllBenefits" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Remove Input Account Benefits
    </h1>
    <div>
        <h2>Input your Mobile Number:
        </h2>
        <asp:TextBox Visible="false" ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
        <br />
        <h2>Input the Plan ID:
        </h2>
        <asp:TextBox Visible="false" ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button Visible="false" ID="Button7" runat="server" CssClass="btn-style" Text="Delete" OnClick="Button7_Click" />
        <br />
        <br />
        <asp:Label ID="Message" runat="server" Text="" CssClass="label"></asp:Label>
    </div>
</asp:Content>

