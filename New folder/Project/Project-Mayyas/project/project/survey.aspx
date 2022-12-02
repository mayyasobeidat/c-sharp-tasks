<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="survey.aspx.cs" Inherits="project.survey" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Survey</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <body>
    

    <!-- Navbar code -->

    <nav id="navbar">
        <img id="logo" src="logo.png">
    </nav>


    <!-- question box -->
    <div class="body-div">

    <div class="question-box" id="quiz-box">

        <div class="question-box-small">

        <h2 id="question">Lorem ipsum dolor sit amet consectetur adipisicing elit oluptates earum deleniti maiores?</h2>

<div class="answer">
    <span class="qu">
        <input id="a" type="radio" name="answer" class="answer">
        <label id="a_text" for="a">Excelent</label>&nbsp;&nbsp;&nbsp;
    </span>

    <span class="qu">
        <input id="b" type="radio" name="answer" class="answer">
        <label id="b_text" for="b">Very good</label>&nbsp;&nbsp;&nbsp;
    </span>

    <span class="qu">
        <input id="c" type="radio" name="answer" class="answer">
        <label id="c_text" for="c">Good</label>&nbsp;&nbsp;&nbsp;
    </span>

    <span class="qu">
        <input id="d" type="radio" name="answer" class="answer">
        <label id="d_text" for="d">Poor</label>
    </span>

</div>  

    </div>

        <div class="butt"><button id="butt" class="submit">Next</button></div>

    </div>
        </div>

    <!-- footer -->

    <footer id="footer1">
        <p id="rights">© 2022 Social Hawk. All Rights Reserved</p>
      </footer>
        </div>
    </form>
</body>
</html>
