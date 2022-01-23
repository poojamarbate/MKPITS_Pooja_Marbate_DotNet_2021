<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web1_DataDisplayIn_SecondFrom.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="40px" Font-Underline="True" Text="Login Form"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Email"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" ForeColor="#0099FF" Text="Forget Password ?"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" BackColor="Blue" Font-Bold="True" Font-Size="16px" ForeColor="White" OnClick="Button1_Click" Text="Login" />
            <br />
        </div>
    </form>
</body>
</html>
