<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="project.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div class="box">
            <div class="row">
             <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
             <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                </div>

            <div class="row">
             <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
             <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>

             <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                   </div>
            <div class="row">
               <div class="but">

                       <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
     </div>
                </div>




        </div>
    </form>
</body>
</html>
