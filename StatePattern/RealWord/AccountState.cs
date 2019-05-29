using System;
using System.Collections.Generic;
using System.Text;
using StatePattern.RealWord;

namespace StatePattern
{
    public abstract class AccountState
    {
        /// <summary>
        /// 状态名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 余额上限
        /// </summary>
        public int LowerLimit { get; set; }
        /// <summary>
        /// 余额下线
        /// </summary>
        public int UpperLimit { get; set; }

        /// <summary>
        /// 处理账户，设置为不同的状态
        /// </summary>
        /// <param name="account"></param>
        public abstract void Process(Account account);
    }
}
