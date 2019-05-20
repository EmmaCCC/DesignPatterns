using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern.RealWord
{
    /// <summary>
    /// 美猴王的师傅
    /// </summary>
    public class Master
    {
        public string Name { get; set; }
        public Master(string name)
        {
            this.Name = name;
        }
    }
}
