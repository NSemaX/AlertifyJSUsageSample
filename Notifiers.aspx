<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Notifiers.aspx.cs" Inherits="Notifiers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Notifier Sample</title>
    <!-- include the script -->    
<script src="alertifyJS/alertify.min.js"></script>
    <!-- include the style -->
<link rel="stylesheet" href="alertifyJS/alertify.min.css" />
<!-- include a theme -->
<link rel="stylesheet" href="alertifyJS/default.min.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button runat="server" Text="Click Success Notifier" ID="notify_btn"   OnClick="notify_btn_Click" />
        <asp:Button runat="server" Text="Click Error Notifier" ID="err_notify_btn"   OnClick="err_notify_btn_Click" />
        <asp:Button runat="server" Text="Click Simple Notifier" ID="simple_notify_btn"   OnClick="simple_notify_btn_Click" />
    </div>
    </form>
</body>
</html>
