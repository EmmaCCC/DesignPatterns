using System;
using System.Collections.Generic;
using System.Text;
using StatePattern.RealWord.States;

namespace StatePattern.RealWord
{
    public class Account
    {
        public AccountState State { get; set; }
        /// <summary>
        /// 账户余额
        /// </summary>
        public int Balance { get; set; }

        public Account()
        {
            this.State = new BronzeVipState();
        }

        public void Save(int amount)
        {
            this.Balance += amount;
            this.State.Process(this);
        }

        public void Consume(int amount)
        {
            this.Balance -= amount;
            this.State.Process(this);
        }

        public void Display()
        {
            Console.WriteLine($"当前余额：{this.Balance}，会员状态：{this.State.Name}[{this.State.LowerLimit}-{this.State.UpperLimit}]");
        }
    }
}
