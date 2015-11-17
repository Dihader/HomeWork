using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Reflection;

namespace FirstHomeWork
{
    public class Controller:IRequiresSessionState
    {
        public HttpContext HttpContext { get; set; }
        public void Execute()
        {
            
        }
        protected void View()
        {

        }
    }
}