using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstHomeWork
{
    public class LogonBinder
    {
        public LogonViewModel BindLogonViewModel(HttpRequest httpRequest)
        {
            LogonViewModel userData = new LogonViewModel();
            if (httpRequest.Form["txtLogin"] != null)
            {
                userData.Login = httpRequest.Form["txtLogin"].ToString();
            }
            else
            {
                userData.Login = "";
            }
            if (httpRequest.Form["txtPassword"] != null)
            {
                userData.Password = httpRequest.Form["txtPassword"].ToString();
            }
            else
            {
                userData.Password = "";
            }
            return userData;
        }
    }
}