using System;
using System.Collections.Generic;
using System.Web;

namespace FirstHomeWork
{
    public class RouteTable
    {
        private Dictionary<string, Action<string>> _methodExecuteDictionary = new Dictionary<string, Action<string>>();
        ControllerFactory _controllerFactory;
        private HttpContext _httpContext;

        public RouteTable()
        {            
            _methodExecuteDictionary.Add("logon", (string verb) =>
            {
                var controller = _controllerFactory.CreateAccountController();
                if (verb.Equals("POST",StringComparison.InvariantCultureIgnoreCase))
                {
                    LogonBinder _logonBinder = new LogonBinder();
                    _logonBinder.BindLogonViewModel(_httpContext.Request);
                    controller.Logon();
                }
            });
        }
        public RouteTable(ControllerFactory controllerFactory):base()
        {
            _controllerFactory = controllerFactory;
        }

        public void CheckURLAndExecuteMethod(HttpContext httpContext)
        {
            string someURL = httpContext.Request.Url.AbsolutePath;
            string verb = httpContext.Request.HttpMethod;
            if (_methodExecuteDictionary.ContainsKey(someURL))
            {
                _methodExecuteDictionary[someURL](verb);
            }
        }
    }
}