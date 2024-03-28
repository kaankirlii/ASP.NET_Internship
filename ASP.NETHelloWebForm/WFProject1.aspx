<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFProject1.aspx.cs" Inherits="ASPHelloWebForm.WFProject1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            First Number:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;&nbsp; Second Number:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        <div>
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Add" GroupName="operation" />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Subtract" GroupName="operation" />
            <asp:RadioButton ID="RadioButton3" runat="server" Text="Multiply" GroupName="operation" />
            <asp:RadioButton ID="RadioButton4" runat="server" Text="Divide" GroupName="operation" />&nbsp;
            <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click" Text="Calculate" 
                BackColor="#00CCFF" ForeColor="Black" />
        </div>
        <div> Result: 
            <asp:Label ID="Label1" runat="server" Text="#"></asp:Label>
        </div>
    </form>
</body>
</html>
