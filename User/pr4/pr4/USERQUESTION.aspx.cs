using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Threading;
using System.Globalization;
using Magnum.FileSystem;
using File = System.IO.File;
using static System.Net.WebRequestMethods;
using System.Collections;
using System.Configuration;

namespace pr4
{public class info
    {
     

    }
    public partial class USERQUESTION : System.Web.UI.Page
    {
        static string user;
        protected void Page_Load(object sender, EventArgs e)
        {
            string Path = "C:\\Users\\dell\\Downloads\\C-TASKS-main\\C-TASKS-main\\pr4\\pr4\\TextFile1.txt";
            string[] quest = File.ReadAllLines(Path);

            Label1.Text = quest[0];
            string path2 = "C:\\Users\\dell\\Downloads\\C-TASKS-main\\C-TASKS-main\\pr4\\pr4\\TextFile2.txt";

            user = Request.QueryString["username"];
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        static int x = 1;
        protected void Button1_Click(object sender, EventArgs e)

        {

            string Path = "C:\\Users\\dell\\Downloads\\C-TASKS-main\\C-TASKS-main\\pr4\\pr4\\TextFile1.txt";
            string[] quest = File.ReadAllLines(Path);

            Label1.Text = quest[x]; 
            string now;
            DateTime date= DateTime.Now;
            
            now = date.ToString("MM-dd-yyyy");
            string path2 = $"C:\\Users\\dell\\Downloads\\C-TASKS-main\\C-TASKS-main\\pr4\\pr4\\{user+ now}.txt";

            using (StreamWriter q = File.AppendText(path2))
            {
                q.Write(quest[x-1] + ":    ");
                if (RadioButton1.Checked == true)
                {
                    q.Write(RadioButton1.Text + "\n");
                    RadioButton1.Checked = false;
                }
                else if (RadioButton2.Checked == true)
                {

                    q.Write(RadioButton2.Text + "\n");
                    RadioButton2.Checked = false;
                }
                else if (RadioButton3.Checked == true)
                {

                    q.Write(RadioButton3.Text + "\n");
                    RadioButton3.Checked = false;
                }
                else if (RadioButton4.Checked == true)
                {
                    q.Write(RadioButton4.Text + "\n");
                    RadioButton4.Checked = false;
                }
            }

            if (x == 10)
            {
                x = 0;
                Response.Redirect("resulttt.aspx?username=" + user);


            }
            
            x++;
            
        }
    }
}

