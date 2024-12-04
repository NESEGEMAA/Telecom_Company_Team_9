<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RemoveAllBenefits.aspx.cs" Inherits="Telecom_Company_Team_9.RemoveAllBenefits" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
        <p>

        </p>
    </form>
</body>
</html>
