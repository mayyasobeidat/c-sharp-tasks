<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="pr4.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="add">
            <h1>ashraf</h1>
            <p>please add questions here</p>
   


           
        </div>
                 <div class="question">
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Question 1" Font-Size="40px" ForeColor="Green"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Height="54px" style="margin-left: 41px" Width="655px"></asp:TextBox>
            </p>
        <p>
            &nbsp;</p>
                      </div>
                       <div class="question">
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Question 2" Font-Size="40px" ForeColor="Green"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Height="54px" style="margin-left: 41px" Width="655px"></asp:TextBox>
            </p>
        <p>
            &nbsp;</p>
                      </div>
                        <div class="question">
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Question 3" Font-Size="40px" ForeColor="Green"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Height="54px" style="margin-left: 41px" Width="655px"></asp:TextBox>
            </p>
        <p>
            &nbsp;</p>
                      </div>


                        <div class="question">
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Question 4" Font-Size="40px" ForeColor="Green"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" Height="54px" style="margin-left: 41px" Width="655px"></asp:TextBox>
            </p>
        <p>
            &nbsp;</p>
                      </div>


                        <div class="question">
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Question 5" Font-Size="40px" ForeColor="Green"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" Height="54px" style="margin-left: 41px" Width="655px"></asp:TextBox>
            </p>
        <p>
           
            &nbsp;</p>
                      </div>

         <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />


         
    </form>
</body>
</html>
