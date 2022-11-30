using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace _30November
{
    public partial class calculator : System.Web.UI.Page
    {
        double number1 , number2 , result ;
        char op;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text+ "1";

        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + ".";

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "4";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "2";

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "3";

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "5";

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "6";

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "7";

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "8";

        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "9";

        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "0";

        }

       

        protected void Button8_Click(object sender, EventArgs e)
        {

        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";

        }

        protected void Button44_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(TextBox1.Text);
            op = '+';
            TextBox1.Text = "";


        }

        protected void Button88_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(TextBox1.Text);
            op = '-';
            TextBox1.Text = "";


        }
        protected void Button111_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(TextBox1.Text);
            op = '×';
            TextBox1.Text = "";


        }

        protected void Button55_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(TextBox1.Text);
            op = '÷';
            TextBox1.Text = "";


        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(TextBox1.Text);
            switch (op)
            {
                case '+':
                    result= number1 + number2;
                    break;
                case '-':
                    result= number1 - number2;
                    break;
                case '×':
                    result= number1 * number2;
                    break;
                case '÷':
                    result= number1 / number2;
                    break;
            }

             TextBox1.Text = Convert.ToString(result);


        }
    }
}