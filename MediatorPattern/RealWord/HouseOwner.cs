using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.RealWord
{
    /// <summary>
    /// 房主
    /// </summary>
    public class HouseOwner : Person
    {
        public HouseOwner(string name, Mediator mediator) : base(name, mediator)
        {
        }

        /// <summary>
        /// 房主发布消息，内部有中介联系
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
            Console.WriteLine($"房东：{Name}，收到消息：{message}");
        }
    }
}
