<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Newsletter_signup.aspx.cs" Inherits="NewsLetter_signup_Form.Newsletter_signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        body{
            background-color:aqua;
        }
        h1{
            color:black;
            text-align:center;
        }
        h4{
            color:black;
            text-align:center;
        }
        
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 1px;
        }
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <h1>&nbsp;&nbsp;SUBSCRIBE&nbsp;</h1>
        <h4>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sign up with your email address to receive news and updates.</h4><br />
        &nbsp;<br />
        <br />
        <br />
        <br />
        <br />
        <br />
        
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server">Enter Name</asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server">Last Name</asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Email">Email Address</asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" ForeColor="Black" Text="SIGN UP" PostBackUrl="~/Data1Form.aspx" />
                </td>
            </tr>
        </table>
        
    </form>
</body>
</html>
