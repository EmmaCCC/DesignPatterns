using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern.RealWord
{
    public abstract class Prototype
    {
        public abstract string Name { get; set; }
        public abstract Prototype Clone();
        
    }
}
