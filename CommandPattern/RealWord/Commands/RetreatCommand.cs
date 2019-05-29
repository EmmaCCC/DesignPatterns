using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.RealWord.Commands
{

    /// <summary>
    /// 撤退命令
    /// </summary>
    public class RetreatCommand : Command
    {
        public string Name { get; set; }
        public RetreatCommand(string name, Soldier soldier) : base(soldier)
        {
            this.Name = name;
        }

        public override void Execute()
        {
            //接受者执行命令
            this.Soldier.Action(Name);
        }
    }
}
