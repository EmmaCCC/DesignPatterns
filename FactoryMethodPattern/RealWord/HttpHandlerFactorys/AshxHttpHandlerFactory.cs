using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodPattern.RealWord.HttpHandlers;

namespace FactoryMethodPattern.RealWord.HttpHandlerFactorys
{
    public class AshxHttpHandlerFactory: IHttpHandlerFactory
    {
        public override IHttpHandler GetHttpHandler()
        {
            return new AshxHttpHandler();
        }
    }
}
