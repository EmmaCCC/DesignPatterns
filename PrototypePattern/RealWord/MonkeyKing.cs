using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern.RealWord
{
    /// <summary>
    /// 美猴王
    /// </summary>
    public class MonkeyKing:Prototype
    {
        /// <summary>
        /// 引用一个师傅
        /// </summary>
        public Master Master { get; set; }

        /// <summary>
        /// 分身的名字（假设每个分身用名字区分）
        /// </summary>
        public override string Name { get ; set ; }

        public MonkeyKing(string name,Master master)
        {
            this.Name = name;
            this.Master = master;
        }

        /// <summary>
        /// 分身变自己，相当于克隆了，克隆出来就是和自己一样能打的猴子
        /// </summary>
        /// <returns></returns>
        public override Prototype Clone()
        {
            return (MonkeyKing) this.MemberwiseClone();
        }
    }
}
