using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.RealWord
{
    public abstract class Command
    {
        public Soldier Soldier;
        protected Command(Soldier soldier)
        {
            this.Soldier = soldier;
        }
        /// <summary>
        /// 执行命令
        /// </summary>
        public abstract void Execute();
    }
}
