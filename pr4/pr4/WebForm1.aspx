<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="pr4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" href="StyleSheet1.css"/>
</head>
<body>
   

    <form id="form1" runat="server">
      
        <div class="box">

            <div class="row">
             <asp:Label ID="Label1" runat="server" Text="user name"></asp:Label>

      <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                </div >

           
            <div class="row">
      <asp:Label ID="Label2" runat="server" Text="password"></asp:Label>

      <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                 <asp:Label ID="Label3" runat="server" Text=""></asp:Label>

              
                 </div>
            <div class="row">
               <div class="but">
              <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />
                   </div>
                </div>




        </div>
    </form>
</body>
</html>
