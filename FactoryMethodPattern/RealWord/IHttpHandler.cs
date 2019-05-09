using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.RealWord
{
    public interface IHttpHandler
    {
        bool CanAccept(string url);
        void ProcessRequest(HttpContext context);
    }
}
