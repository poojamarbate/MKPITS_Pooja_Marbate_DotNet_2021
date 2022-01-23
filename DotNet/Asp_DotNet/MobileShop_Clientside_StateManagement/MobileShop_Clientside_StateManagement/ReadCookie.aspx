<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadCookie.aspx.cs" Inherits="MobileShop_Clientside_StateManagement.ReadCookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Selected items :"></asp:Label>
            <br />
            <br />
            <asp:BulletedList ID="BulletedList1" runat="server">
            </asp:BulletedList>
        </div>
    </form>
</body>
</html>
