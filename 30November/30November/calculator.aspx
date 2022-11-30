<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculator.aspx.cs" Inherits="_30November.calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" BackColor="#F0F0F0" BorderColor="Black" BorderStyle="Solid" Enabled="False" Font-Size="Medium" ForeColor="Black" Height="65px" OnTextChanged="TextBox1_TextChanged" Width="285px"></asp:TextBox>
            <br />
            <br />
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" BorderColor="Black" BorderStyle="Solid" Height="58px" OnClick="Button1_Click" Text="1" Width="65px" />
&nbsp;
        <asp:Button ID="Button2" runat="server" BorderColor="Black" BorderStyle="Solid" Height="58px" OnClick="Button2_Click" Text="2" Width="65px" />
&nbsp;
        <asp:Button ID="Button3" runat="server" BorderColor="Black" BorderStyle="Solid" Height="58px" OnClick="Button3_Click" Text="3" Width="65px" />
&nbsp;
        <asp:Button ID="Button4" runat="server" BorderColor="Black" BorderStyle="Solid" Height="58px" OnClick="Button44_Click" Text="+" Width="65px" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" BorderColor="Black" BorderStyle="Solid" Height="58px" OnClick="Button4_Click" Text="4" Width="65px" />
&nbsp;
        <asp:Button ID="Button6" runat="server" BorderColor="Black" BorderStyle="Solid" Height="58px" OnClick="Button5_Click" Text="5" Width="65px" />
&nbsp;
        <asp:Button ID="Button7" runat="server" BorderColor="Black" BorderStyle="Solid" Height="58px" OnClick="Button6_Click" Text="6" Width="65px" />
&nbsp;
        <asp:Button ID="Button8" runat="server" BorderColor="Black" BorderStyle="Solid" Height="58px" Text="-" Width="65px" OnClick="Button88_Click" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button9" runat="server" BorderColor="Black" BorderStyle="Solid" Height="58px" OnClick="Button9_Click" Text="7" Width="65px" />
&nbsp;
        <asp:Button ID="Button10" runat="server" BorderColor="Black" BorderStyle="Solid" Height="58px" OnClick="Button10_Click" Text="8" Width="65px" />
&nbsp;
        <asp:Button ID="Button11" runat="server" BorderColor="Black" BorderStyle="Solid" Height="58px" OnClick="Button11_Click" Text="9" Width="65px" />
&nbsp;
        <asp:Button ID="Button12" runat="server" BorderColor="Black" BorderStyle="Solid" Height="58px" OnClick="Button111_Click" Text="×" Width="65px" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button13" runat="server" BorderColor="Black" BorderStyle="Solid" Height="58px" OnClick="Button13_Click" Text="0" Width="65px" />
&nbsp;
        <asp:Button ID="Button14" runat="server" BorderColor="Black" BorderStyle="Solid" Height="58px" OnClick="Button14_Click" Text="." Width="65px" />
&nbsp;
        <asp:Button ID="Button17" runat="server" BorderColor="Black" BorderStyle="Solid" Height="58px" OnClick="Button17_Click" Text="Clear" Width="65px" />
&nbsp;
        <asp:Button ID="Button16" runat="server" BorderColor="Black" BorderStyle="Solid" Height="58px" OnClick="Button55_Click" Text="÷" Width="65px" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button15" runat="server" BorderColor="Black" BorderStyle="Solid" Height="65px" OnClick="Button15_Click" Text="=" Width="290px" />
    &nbsp;</form>
</body>
</html>
