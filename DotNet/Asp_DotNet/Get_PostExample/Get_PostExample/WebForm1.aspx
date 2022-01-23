<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Get_PostExample.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 34%;
            height: 205px;
            background-color: #FF6600;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <center>
        <table class="auto-style1">
            <tr>
                <td colspan="2">Get Method Example</td>
            </tr>
            <tr>
                <td>Name</td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="............."></asp:Label>
                </td>
            </tr>
            <tr>
                <td>City</td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="............"></asp:Label>
                </td>
            </tr>
        </table>
       </center> 
    </form>
</body>
</html>
