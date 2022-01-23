<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FullPageCache_Example.aspx.cs" Inherits="CachingExample.FullPageCache_Example" %>
<%@OutPutCache Duration="15" VaryByParam="None"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            This is a FullPage caching Example
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Time"></asp:Label>
            <br />
            Client Time:</div>
    </form>
</body>
</html>
