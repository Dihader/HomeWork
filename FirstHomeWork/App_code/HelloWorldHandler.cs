using System.Web;
using System;
public class HelloWorldHandler : IHttpHandler
{
    public HelloWorldHandler()
    {
    }
    public void ProcessRequest(HttpContext context)
    {

        HttpRequest req = context.Request;
        HttpResponse res = context.Response;
       
        res.Write("<html>");
        res.Write("<body>");
        if (req.HttpMethod == "GET")
        {
            res.Write("<h1>GET</h1>");   
        }
        else if (req.HttpMethod == "POST")
        {
            res.Write("<h1>POST</h1>");
        }
        else
        {
            res.Write("<h1>Else work.</h1>");
        }
        res.Write("</body>");
        res.Write("</html>");
        


    }
    public bool IsReusable
    {
        get { return true; }
    }
}