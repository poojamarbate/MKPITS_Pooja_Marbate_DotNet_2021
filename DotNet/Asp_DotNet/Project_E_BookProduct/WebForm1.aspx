<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Project_E_BookProduct.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        width: 264px;
        height: 93px;
    }
    .auto-style3 {
        width: 159px;
    }
    .auto-style4 {
        width: 135px;
    }
    .auto-style5 {
        height: 26px;
    }
    .auto-style6 {
        width: 159px;
        height: 29px;
    }
    .auto-style7 {
        width: 135px;
        height: 29px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style2">
    <tr>
        <td colspan="2">&nbsp;<asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="20px" Font-Underline="True" Text="Register Form"></asp:Label>
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="2">Create your account .it&#39;s free and only takes a minute.</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="15px" Text="First Name"></asp:Label>
        </td>
        <td class="auto-style4">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="15px" Text="Last Name"></asp:Label>
        </td>
        <td class="auto-style4">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style6">
            <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="15px" Text="Password"></asp:Label>
        </td>
        <td class="auto-style7">
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="15px" Text="Confirm Password"></asp:Label>
        </td>
        <td class="auto-style4">
            <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:CheckBox ID="CheckBox1" runat="server" Text=" I accept the " />
            <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="15px" Text="Terms of use "></asp:Label>
            &amp;
            <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="15px" Text="Privacy Policy."></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" BackColor="#00CC00" Font-Bold="True" ForeColor="White" Text="Register Now" OnClick="Button1_Click" />
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
    </tr>
</table>
</asp:Content>
