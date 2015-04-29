<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>Alertify Usage</title>
    <!-- include the script -->    
<script src="alertifyJS/alertify.min.js"></script>
    <!-- include the style -->
<link rel="stylesheet" href="alertifyJS/alertify.min.css" />
<!-- include a theme -->
<link rel="stylesheet" href="alertifyJS/default.min.css" />
     <script type="text/javascript">
        function clickedButton() {
            alert('Hello');
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button runat="server" Text="Click Me" ID="hello_btn"  OnClick="hello_btn_Click" />

     <button onclick="clickedButton()">Click Me 1</button>
    </div>
    </form>
</body>
</html>
