using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstHomeWork
{
    public class ViewFactory
    {
        public LogonView CreateView()
        {
            return new LogonView();
        }
    }
}