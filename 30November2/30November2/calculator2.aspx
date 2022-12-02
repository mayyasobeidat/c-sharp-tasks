<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculator2.aspx.cs" Inherits="_30November2.calculator2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 1050px; height: 538px;">
    <form id="form1" runat="server">

        <img src ="1.png" />

        <div style="border-style: solid; width: 505px; display : flex ; flex-direction : column; align-content : center ; align-items:center">

        <p>
        &nbsp;&nbsp;&nbsp;
        <asp:Label Style ="background-color:lightgray; " ID="Label1" runat="server" Text="First Number"  Font-Size="X-Large"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label Style ="background-color:lightgray; " ID="Label2" runat="server" Text="Second Number"  Font-Size="X-Large"></asp:Label>
       </p>
        
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="50px" Width="200px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Height="50px" Width="200px"></asp:TextBox>
        </p>
     
        <p style="width: 418px">
            <asp:Button ID="Button1" Font-Size="XX-Large" runat="server" Height="60px" OnClick="Button1_Click" Text="+" Width="100px" />
            <asp:Button ID="Button2" Font-Size="XX-Large" runat="server" Height="60px" OnClick="Button2_Click" Text="-" Width="100px" />
            <asp:Button ID="Button3" Font-Size="XX-Large" runat="server" Height="60px" OnClick="Button3_Click" Text="×" Width="100px" />
            <asp:Button ID="Button4" Font-Size="XX-Large" runat="server" Height="60px" OnClick="Button4_Click" Text="÷" Width="100px" />
        </p>

        <p style="border-style: solid; width: 400px; text-align: center; background-color: #FFFFFF; ">
        <asp:Label ID="Label3" runat="server" Font-Size="XX-Large" Text="Result"></asp:Label>
        <br />
        <asp:Label Style="color:lightgreen" ID="Label4" runat="server" Font-Size="XX-Large" Text="00"></asp:Label>
    </p>
            </div>
            </form>
</body>
</html>
