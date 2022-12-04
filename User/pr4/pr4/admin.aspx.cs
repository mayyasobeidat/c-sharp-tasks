using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pr4
{
    public partial class admin : System.Web.UI.Page
    {
        private string A;

        protected void Page_Load(object sender, EventArgs e)
        {
 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Path = Server.MapPath("TextFile1.txt");
            using (StreamWriter q = File.AppendText(Path))
            {
                q.WriteLine(TextBox1.Text);
                q.WriteLine(TextBox2.Text);
                q.WriteLine(TextBox3.Text);
                q.WriteLine(TextBox4.Text);
                q.WriteLine(TextBox5.Text);
            }
        }
    }
}