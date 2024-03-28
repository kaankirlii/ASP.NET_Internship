<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFProject5.aspx.cs" 
    Inherits="ASPHelloWebForm.WFProject5" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Guess The Number</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter a number (1-10): "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="68px">
            </asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guess" />
            <br/>
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
