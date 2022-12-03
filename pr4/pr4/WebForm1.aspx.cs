using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pr4
{class checkUser
    {
     
       



        }


   


    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
           

      
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string[] employees = { "mayyas", "mosab", "suhaib", "ahmad", "moaath" };
            string[] password = { "123", "456", "789", "147", "258", "369" };
            string adminname = "ashraf";

            string adminpass = "1234";

            //Response.Write(Label2.Text);
            //Console.Write(Label2.value);
            if (TextBox1.Text != ""&&TextBox2.Text!="") { 
                if(adminname==TextBox1.Text&&adminpass==TextBox2.Text) {

                    Response.Redirect("admin.aspx?username="+ TextBox1.Text);
                }

                else { 
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == TextBox1.Text && password[i] == TextBox2.Text)
                {

                    Response.Redirect("WECOMING.aspx?username=" + TextBox1.Text );
                            

                    break;
                }
                else
                {
                    Label3.Text = "YOU are not welcoming";

                }

            }

                }
            }
            else
            {
                Label3.Text = "please two field is required";
            }

        }
    }
}