<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Disconnected_Architecture.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 630px;
            height: 469px;
        }
        .auto-style3 {
            width: 154px;
            height: 61px;
        }
        .auto-style6 {
            height: 25px;
        }
        .auto-style7 {
            height: 57px;
        }
        .auto-style8 {
            height: 36px;
        }
        .auto-style9 {
            height: 42px;
        }
        .auto-style10 {
            height: 47px;
        }
        .auto-style11 {
            height: 61px;
        }
    </style>
</head>
<body style="height: 685px">
    <form id="form1" runat="server">
        
        <table class="auto-style1">
            <tr>
                <td class="auto-style6" colspan="4">
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="20px" Font-Underline="True" Text="CRUD operation"></asp:Label>
                    <br />
                    Categories&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
            </tr>
            <tr>
                <td class="auto-style7" colspan="2">
                    <asp:Label runat="server" Text="Product Name"></asp:Label>
                </td>
                <td class="auto-style7" colspan="2">
                    <asp:TextBox ID="txtproductname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8" colspan="2">
                    <asp:Label ID="Label2" runat="server" Text="Price"></asp:Label>
                </td>
                <td class="auto-style8" colspan="2">
                    <asp:TextBox ID="txtprice" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9" colspan="2">
                    <asp:Label ID="Label3" runat="server" Text="Manufacturing Date"></asp:Label>
                </td>
                <td class="auto-style9" colspan="2">
                    <asp:TextBox ID="txtmfd" runat="server" TextMode="Date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="4" class="auto-style10">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Llbmessage" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="25px" ForeColor="Blue" Text="message"></asp:Label>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">
                    <asp:Button ID="btnadd" runat="server"  Text="ADD" OnClick="btnadd_Click" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="btnchange" runat="server" Text="CHANGE" OnClick="btnchange_Click" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="btndelete" runat="server" Text="DELETE" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="btnclear" runat="server" Text="CLEAR" />
                </td>
            </tr>
        </table>
        
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        
    </form>
</body>
</html>
