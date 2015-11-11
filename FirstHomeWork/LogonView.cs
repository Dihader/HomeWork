using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstHomeWork
{
    public class LogonView
    {
        public LogonView()
        {

        }
        public void BilderHtml(LogonViewModel loginViewModel)
        {
            HttpContext.Current.Response.Write("<html>");
            HttpContext.Current.Response.Write("<body>");
            string password = String.Format("<h2> Password:{0} </h2>", loginViewModel.Password);
            string login = String.Format("<h2> Login:{0} </h2>", loginViewModel.Login);
            HttpContext.Current.Response.Write(password);
            HttpContext.Current.Response.Write(login);
            HttpContext.Current.Response.Write("</body>");
            HttpContext.Current.Response.Write("</html>");
        }

    }
}