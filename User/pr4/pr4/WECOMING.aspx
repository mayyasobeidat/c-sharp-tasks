<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WECOMING.aspx.cs" Inherits="pr4.WECOMING" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">
            <asp:Label ID="Label1" runat="server" Font-Size="50px" ForeColor="#66FF66"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Start Survey" OnClick="Button1_Click" Width="120px"/>
        </div>
    </form>
</body>
</html>
