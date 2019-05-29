using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.RealWord
{
    /// <summary>
    /// 司令员指挥官
    /// </summary>
    public class Commander
    {
        public Command Command { get; set; }

        /// <summary>
        /// 发出命令
        /// </summary>
        public void SendCommand()
        {
            this.Command.Execute();
        }
    }
}
