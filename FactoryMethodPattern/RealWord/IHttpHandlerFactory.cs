using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.RealWord
{
    public abstract class IHttpHandlerFactory
    {
        public abstract IHttpHandler GetHttpHandler();
    }
}
