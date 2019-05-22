using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.RealWord
{
    /// <summary>
    /// 租客
    /// </summary>
    public class Renter : Person
    {
        public Renter(string name, Mediator mediator) : base(name, mediator)
        {
        }

        /// <summary>
        /// 租借也发布消息，内部有由中介联系
        /// </summary>
        /// <param name="message"></param>
        public override void SendMessage(string message)
        {
            Mediator.Contact(message, this);
        }

        /// <summary>
        /// 获取消息展示
        /// </summary>
        /// <param name="message"></param>
        public override void GetMessage(string message)
        {
            Console.WriteLine($"租客：{Name}，收到消息：{message}");
        }
    }
}
