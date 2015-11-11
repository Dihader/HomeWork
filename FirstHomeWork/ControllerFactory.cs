using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstHomeWork
{
    public class ControllerFactory
    {
        public AccountController CreateAccountController()
        {
            return new AccountController();           
        }
    }
}