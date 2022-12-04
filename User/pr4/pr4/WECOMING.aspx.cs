using Magnum.Cryptography.PKI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using File = System.IO.File;
using System.IO;
using Magnum.FileSystem;

namespace pr4
{
    public partial class WECOMING : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Request.QueryString["username"];
            Label1.Text ="Hello"+" " +user;
        }
        
        static DateTime date =DateTime.Now;
        public string path = $"C:\\Users\\dell\\Downloads\\C-TASKS-main\\C-TASKS-main\\pr4\\pr4\\{"ppp"+date}.txt";

        private static object user;


        protected void Button1_Click(object sender, EventArgs e)
        {
            string user = Request.QueryString["username"];
            
            Response.Redirect("USERQUESTION.aspx?username=" + user);

            FileStream fs = null;
            fs = new FileStream("ooo", FileMode.CreateNew);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write("ppppppppppppppp");
            }
        }        
    }
}