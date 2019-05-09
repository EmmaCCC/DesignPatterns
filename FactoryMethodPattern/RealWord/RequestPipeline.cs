using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodPattern.RealWord.HttpHandlerFactorys;

namespace FactoryMethodPattern.RealWord
{
    public class RequestPipeline
    {
        //默认内置了 2 个http处理器
        private List<IHttpHandlerFactory> _httpHandlerFactories = new List<IHttpHandlerFactory>()
        {
            new AspxHttpHandlerFactory(),
            new AshxHttpHandlerFactory()
        };

        private HttpContext _context;
        public RequestPipeline(HttpContext context)
        {
            this._context = context;
        }

        public void GetProcessResult()
        {
            foreach (var httpHandlerFactory in _httpHandlerFactories)
            {
                IHttpHandler httpHandler = httpHandlerFactory.GetHttpHandler();
                if (httpHandler.CanAccept(_context.Request))
                {
                    httpHandler.ProcessRequest(_context);
                }
            }
        }

        /// <summary>
        /// 传统没有设计模式的实现
        /// </summary>
        public void GetProcessResult2()
        {
            //非常简单，几行代码，但是怎么扩展呢，你这个框架或者类库都写好给别人用了，难不成都去修改你里边的代码？
            //我要想去掉一个请求处理呢，是不是得删了这段代码呢
            if (_context.Request.EndsWith(".aspx"))
            {
                Console.WriteLine("这是一个aspx页面请求，我处理了,返回<html><div>aspx页面</div></html>");
            }
            if (_context.Request.EndsWith(".ashx"))
            {
                Console.WriteLine("这是一个一般处理程序请求，我处理了,返回 200 ");
            }
        }

        public void RegisterIHttpHandlerFactory(IHttpHandlerFactory httpHandlerFactory)
        {
            this._httpHandlerFactories.Add(httpHandlerFactory);
        }
    }
}
