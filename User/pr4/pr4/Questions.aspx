﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Questions.aspx.cs" Inherits="pr4.Questions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" href="ADDQUESTIONs-CSS.css" />
    <script src="https://kit.fontawesome.com/e869edadc1.js" crossorigin="anonymous"></script>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
<!-- navbar start -->
        <nav id="navbar">
            <div>
            <img id="logo" src="logo.png"/>
            </div>
                <div>   
                    <ul>
                        <li>
                            <a class="navLinks" href="#">
                            Home
                            </a>
                        </li>
                        <li>
                            <a class="navLinks" href="#">
                                Logout
                                </a>
                        </li>
                    </ul>
                </div>
        </nav>
    
        <!-- navbar end -->
        <!-- side bar start -->
        
        <div class="app">
            <div class="menu-toggle">
                <div class="hamburger">
                    <span></span>
                </div>
            </div>
    
            <aside class="sidebar">
                <p>Welcome, Amer</p>
                
                <div class="menu">
                    <a href="http://localhost:63412/Test.aspx" class="menu-item ">Results</a>
                    <a href="#" class="menu-item is-active">Questions</a>
                    <div>
                        
                     <a href="#" class="menu-item">Employees</a>
                </div>
                </div>
    
            </aside>
    

    <main clas="main">    
    <form id="form1" runat="server">
       
<div class="bigdiv" id="aa" runat="server" > <div class="label1"><asp:Label ID="Label1" Class="" runat="server"  Text="Write Question With Corresponding Number"></asp:Label></div><asp:TextBox ID="Textbox" runat="server" CssClass="input1"></asp:TextBox></div>  
      
            <br />
        <div class="function"> 
        <div class="function1"><asp:Button ID="Button2" runat="server" Class="button"  Text="View" OnClick="Button2_Click" /></div>
        <div class="function1"><asp:Button ID="Button1" runat="server" Class="button" Text="Add"  OnClick="Button1_Click1" /></div>
        </div><br />
    </form>
        </main>

    
        <script>
            const menu_toggle = document.querySelector('.menu-toggle');
            const sidebar = document.querySelector('.sidebar');
    
                menu_toggle.addEventListener('click', () => {
                menu_toggle.classList.toggle('is-active');
                sidebar.classList.toggle('is-active');
            });
        </script>
</body>
</html>
