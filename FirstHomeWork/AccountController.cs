using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace FirstHomeWork
{
    public class AccountController:IRequiresSessionState
    {
        LogonBinder _logonBinder;
        LogonViewModel _logonViewModel;
        LogonView _logonView;
        ViewFactory _viewFactory;

        public AccountController()
        {
            _logonBinder = new LogonBinder();
            _logonViewModel = new LogonViewModel();
            _viewFactory = new ViewFactory();
            _logonView = _viewFactory.CreateView();
        }
        public void LogonWithGet(HttpContext context)
        {
            HttpRequest req = context.Request;
            HttpResponse res = context.Response;        
       
            if (req.QueryString["txtLogin"] != null)
            {
                _logonViewModel.Login = req.QueryString["txtLogin"];
            }
            else
            {
                _logonViewModel.Login = "";
            }
            if (req.QueryString["txtPassword"] != null)
            {
                _logonViewModel.Password = req.QueryString["txtPassword"];
            }
            else
            {
                _logonViewModel.Password = "";
            }
            _logonView.BilderHtml(_logonViewModel);
        }
        public void LogonWithPost(HttpContext context)
        {
            HttpRequest req = context.Request;
            HttpResponse res = context.Response;

            _logonViewModel = _logonBinder.BindLogonViewModel(req);
            _logonView.BilderHtml(_logonViewModel);
        }
    }
}