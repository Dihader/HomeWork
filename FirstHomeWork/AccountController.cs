using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstHomeWork
{
    public class AccountController:Controller
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

        public void Logon()
        {
            _logonView.BilderHtml(_logonViewModel);
        }

        public void Logon(LogonViewModel model)
        {
            //HttpRequest req = context.Request;         
           // _logonViewModel = _logonBinder.BindLogonViewModel(req);            
           // _logonView.BilderHtml(_logonViewModel);
            _logonView.BilderHtml(model);
        }
    }
}