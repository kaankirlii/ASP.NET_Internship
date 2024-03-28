<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFProject6.aspx.cs" 
    Inherits="ASPHelloWebForm.WFProject6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ImageButton</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ImageButton ID="ImageButton1" runat="server" Height="300px" Width="300px" 
                ImageUrl="~/asp_net-300x300.png" OnClick="ImageButton1_Click" 
                PostBackUrl="https://asp.net/" />
        </div>
    </form>
</body>
</html>
