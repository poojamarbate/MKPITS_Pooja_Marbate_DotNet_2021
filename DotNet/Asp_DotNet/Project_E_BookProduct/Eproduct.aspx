<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Eproduct.aspx.cs" Inherits="Project_E_BookProduct.Eproduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 365px;
            background-color: #CCCCCC;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style2">
        <tr>
            <td colspan="4">
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="25px" Font-Underline="True" Text="Book Details"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="20px" Text="Book Categories"></asp:Label>
            </td>
            <td colspan="2">
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="15px" Text="Bookname"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="15px" Text="Book Price"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Size="15px" Text="Published Date"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2"></td>
            <td colspan="2"></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnadd" runat="server" OnClick="btnadd_Click" Text="ADD" />
            </td>
            <td>
                <asp:Button ID="btnupdate" runat="server" Text="UPDATE" />
            </td>
            <td>
                <asp:Button ID="btndelete" runat="server" Text="DELETE" />
            </td>
            <td>
                <asp:Button ID="btnclear" runat="server" Text="CLEAR" />
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="Lmsg" runat="server" Font-Bold="True" Font-Size="15px" Text="......................."></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
