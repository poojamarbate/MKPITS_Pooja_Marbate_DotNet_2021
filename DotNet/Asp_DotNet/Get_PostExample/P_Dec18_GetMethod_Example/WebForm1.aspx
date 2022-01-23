<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="P_Dec18_GetMethod_Example.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
            <caption><h2>Register</h2></caption>
            <p><h5>Please fill in this form to create an account.</h5>

        <table class="auto-style1">
            <tr>
                <td></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <input id="Text1" type="text" /></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <input id="Text2" type="text" /></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Repeat Password"></asp:Label>
            <table class="auto-style1">
                <tr>
                    <td>
                        <input id="Text3" type="text" /></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <input id="Checkbox1" type="checkbox" /> By creating an account you agree to our terms &amp; condition.</td>
                </tr>
                <tr>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <input id="Submit1" type="submit" value="Register" /></td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
