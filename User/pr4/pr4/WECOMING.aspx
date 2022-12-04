<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WECOMING.aspx.cs" Inherits="pr4.WECOMING" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="StyleSheetWelcome.css"/>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Welcome page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <section class="home" id="home">
        <nav>
            <image id="imgg" src="ppppp.png" width="240px"/>
            <ul>
                <li><a id ="logIn">Log Out</a></li>
            </ul>
        </nav>
     </section>  
       <div class="content">
        <div class="container-texts">
            <asp:Label ID="Label1" runat="server" CssClass="well"></asp:Label>
            <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Error harum nesciunt maiores accusantium nostrum molestias ad non sit quam maxime quos odit praesentium quibusdam, repellendus amet? Rerum vitae dolores id.</p>          
         <div class="classDiv"><asp:Button ID="Button2" runat="server" Text="Start Survey" OnClick="Button1_Click" class="buttn"/></div>
        </div>
        <div class=""><img src="home2.png" alt="" class="pic" width="600px"/></div>
      </div>
            

    
        </div>

        <footer id="footer1"><p id="rights">© 2022 Social Hawk. All Rights Reserved</p></footer>

        <div class="footer">
        <div class="content-footer"><h4>© 2022 Social Hawk. All Rights Reserved</h4></div>
     </div>
    </form>
</body>
</html>
