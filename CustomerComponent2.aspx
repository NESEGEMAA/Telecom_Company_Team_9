<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerComponent2.aspx.cs" Inherits="Telecom_Company_Team_9.CustomerComponent2" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 2120px">
    <form id="form1" runat="server">
        <div>
            <!-- Part 1-->
            <h2>View all Active Benefits</h2>
            <br />
            <br />
            <asp:Button ID="ButtonView" runat="server" Text="Click Here" OnClick ="ViewBenefits"/>
            <br />
            <br />
             <asp:GridView ID="GridBenefitView" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
            </asp:GridView>

           
            <br />
            <br />
            <asp:Label ID="BenefitErrorMessage" runat="server"></asp:Label>
            <br />

           
            <br />
            <!-- Part 2-->
              <h2>Check for Unresolved Tickets Here </h2>
            <br />
                <p1> Enter National ID:</p1>
                
                <br />
             <asp:TextBox ID="NID" runat="server" Placeholder="Enter National ID"></asp:TextBox>
             <br />
    
            <br />
            <asp:Button ID="ButtonTickets" runat="server" Text="Check" OnClick="ViewTickets" />

            <br />
            <br />
            <asp:Label ID="lblTicketCount" runat="server" ></asp:Label>
                
            <!-- Part 3-->
            <h2>Checking Highest Voucher ID</h2>
            
            <br />
            Mobile Number:<br />
             <asp:TextBox ID="mobi" runat="server"></asp:TextBox>
             <br />
            <br />
            
            
            <asp:Button ID="ButtonVocuher" runat="server" Text="Check" OnClick="ViewVoucher" />
            <br />
            <br />

            <asp:Label ID="LabelVoucher" runat="server" Visible="false" ></asp:Label>
            <br />
            <br />

            <!-- Part 4-->
            <h2> Check Here for Remaining balance on the account </h2>
            <br />
            <br />
            Mobile Number:<br />
            <asp:TextBox ID="mobileNumR" runat="server"></asp:TextBox>
            <br />
            Plan name:<br />
            <asp:TextBox ID="plannameR" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ButtonRemAmount" runat="server" Text="Check" OnClick ="ViewRemainingAmount" />
            <br />
            <br />
            <asp:Label ID="LabelRem" runat="server" ></asp:Label>
            <br />
            <br />
                
            <br />
            <!--Part 5-->
            <h2>Check Here for the Extra Balance on the account</h2>
            <br />
            Mobile Number:<br />
            <asp:TextBox ID="mobileNumE" runat="server"></asp:TextBox>
            <br />
            Plan name:<br />
            <asp:TextBox ID="plannameE" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ButtonExtAmount" runat="server" Text="Check" OnClick ="ViewExtraAmount" />
            <br />
            <br />
            <asp:Label ID="LabelExt" runat="server" ></asp:Label>
            <br />

            <br />
            <br />
            <!-- Part 6-->
            <h2>Check Top 10 Successful Payments on the account</h2><br />
            Mobile Number:<br />
            <asp:TextBox ID="mob" runat="server"></asp:TextBox>
            <br />
            <br />
        
             <asp:Button ID="ButtonPayment" runat="server" Text="View Payments" OnClick="PaymentView" />
            <asp:GridView ID="GridViewPayment" runat="server"> </asp:GridView>
            <br />
            <asp:Label ID="LabelPayment" runat="server" ></asp:Label>
            <br />
            <br />
            <br />
            <br />
        
            
        </div>
    </form>
</body>
</html>

