using System.Web;
using System;
using System.Collections.Specialized;
using System.Web.SessionState;
using FirstHomeWork;

public class HelloWorldHandler : IHttpHandler, IRequiresSessionState
{
    ControllerFactory _controllerFactory;
    AccountController _accountController;
    RouteTable _routeTable;

    public HelloWorldHandler()
    {
        _controllerFactory = new ControllerFactory();
        _accountController = _controllerFactory.CreateAccountController();
    }
    public void ProcessRequest(HttpContext context)
    {       
        _routeTable = new RouteTable(_controllerFactory);
        _routeTable.CheckURLAndExecuteMethod(context);
    }
    public bool IsReusable
    {
        get { return true; }
    }
}