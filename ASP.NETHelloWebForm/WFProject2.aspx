<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFProject2.aspx.cs" 
    Inherits="ASPHelloWebForm.WFProject2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Factorial</title>
</head>
<body style="background-color:chocolate">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter a number: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calculate"
                BackColor="#003300" 
                BorderStyle="Solid" ForeColor="#FFFFCC" />
        </div>
        <div>
            Factorial Result: <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
