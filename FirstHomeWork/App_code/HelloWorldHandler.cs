using System.Web;
using System;
using System.Collections.Specialized;
using System.Web.SessionState;
using FirstHomeWork;
public class HelloWorldHandler : IHttpHandler,IRequiresSessionState
{
    ControllerFactory _controllerFactory;
    AccountController _accountController;

    public HelloWorldHandler()
    {
        _controllerFactory = new ControllerFactory();
         _accountController = _controllerFactory.CreateAccountController();
    }
    public void ProcessRequest(HttpContext context)
    {

        HttpRequest req = context.Request;
        HttpResponse res = context.Response;        
        
        if (req.HttpMethod == "GET")
        {
            _accountController.LogonWithGet(context);
        }
        if (req.HttpMethod == "POST")
        {
           _accountController.LogonWithPost(context);        
        }
    }
    public bool IsReusable
    {
        get { return true; }
    }
}