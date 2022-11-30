using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _30November2
{

    public partial class calculator2 : System.Web.UI.Page
    {
        double number1;
        double number2;
        double result;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(TextBox1.Text);
            number2 = Convert.ToDouble(TextBox2.Text);
            result = number1 + number2;
            Label4.Text = Convert.ToString(result);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(TextBox1.Text);
            number2 = Convert.ToDouble(TextBox2.Text);
            result = number1 - number2;
            Label4.Text = Convert.ToString(result);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(TextBox1.Text);
            number2 = Convert.ToDouble(TextBox2.Text);
            result = number1 * number2;
            Label4.Text = Convert.ToString(result);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(TextBox1.Text);
            number2 = Convert.ToDouble(TextBox2.Text);
            result = number1 / number2;
            Label4.Text = Convert.ToString(result);
        }
    }
}