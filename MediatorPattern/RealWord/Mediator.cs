using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.RealWord
{
    public abstract class Mediator
    {
        /// <summary>
        /// 中介联系方法
        /// </summary>
        /// <param name="message">消息</param>
        /// <param name="person">消息的发送人，不是接收人</param>
        public abstract void Contact(string message, Person person);
    }
}
