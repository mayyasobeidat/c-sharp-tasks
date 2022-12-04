using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pr4
{class checkUser { }
    

    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e){}
        protected void TextBox1_TextChanged(object sender, EventArgs e){}
        protected void Button1_Click(object sender, EventArgs e)
        {

            string[] employees = { "Amer@gmail.com", "mayyas@gmail.com", "mosab@gmail.com", "suhaib@gmail.com", "ahmadodat@gmail.com", "moaath@gmail.com", "razan@gmail.com", "qais@gmail.com", "roaa@gmail.com", "haitham@gmail.com" };
            string[] password = { "03", "15", "21", "33", "01", "23", "30", "25", "32", "09" };
            string adminname = "ashraf@gmail.com";
            string adminpass = "04";


            string user_result = Server.MapPath("Texts");
            var user = Directory.EnumerateFiles(user_result).Select(Path.GetFileName);
            bool flag = true;
            if (flag) { }

            if (TextBox1.Text != "" && TextBox2.Text != "")
            {
                if (adminname == TextBox1.Text && adminpass == TextBox2.Text)
                {
                    Response.Redirect("admin.aspx?username=" + TextBox1.Text);
                }

                else
                {
                    for (int i = 0; i < employees.Length; i++)
                    {
                        if (employees[i] == TextBox1.Text && password[i] == TextBox2.Text)
                        {
                            foreach (string check in user)
                            {
                                string[] name = check.Split('-');
                                if (TextBox2.Text == name[0])
                                {
                                    flag = false;
                                    break;
                                }
                            }
                            if (flag)
                            {
                                Response.Redirect("WECOMING.aspx?username=" + TextBox1.Text + "&password=" + TextBox2.Text);
                            }
                            else
                            {
                                Response.Write("<script> alert('You took the survey ') </script>");
                            }

                        }
                        else
                        {
                            Label3.Text = "You are not welcoming";
                        }
                    }
                }
            }
            else
            {
                Label3.Text = "Please two field is required";
            }


        }
    }
}