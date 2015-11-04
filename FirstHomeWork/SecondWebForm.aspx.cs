using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstHomeWork
{
    public partial class SecondWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form.Count>=2)
            {
                lblLogin.Text += Request.Form["txtLogin"].ToString();
                lblPassword.Text += Request.Form["txtPassword"].ToString();
            }
            

        }
        
       
    }
}