<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Master_Page_Example.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100px">
    <tr>
        <td colspan="2" style="height: 9px">
            <asp:Label ID="Label2" runat="server" Text="Products" SkinID="Head"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:ListBox ID="ListBox1" runat="server">
                <asp:ListItem Value="camera"></asp:ListItem>
                <asp:ListItem Value="Desktop"></asp:ListItem>
                <asp:ListItem Value="Laptop"></asp:ListItem>
                <asp:ListItem Value="Mobile"></asp:ListItem>
            </asp:ListBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
