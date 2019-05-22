using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.RealWord
{
    /// <summary>
    /// 链家中介
    /// </summary>
    public class LianJiaMediator:Mediator
    {
        public HouseOwner HouseOwner { get; set; }
        public Renter Renter { get; set; }


        public override void Contact(string message, Person person)
        {
            //如果发送人是房东
            if (person == HouseOwner)
            {
                //那么租客获得消息
                Renter.GetMessage(message);
            }
            else
            {
                //反之房东获得消息
                HouseOwner.GetMessage(message);
            }
        }
    }
}
