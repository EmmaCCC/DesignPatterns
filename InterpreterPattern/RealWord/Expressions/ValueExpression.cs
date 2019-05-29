using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.RealWord.Expressions
{
    public class ValueExpression : Expression
    {
        private int value;
        public ValueExpression(int value)
        {
            this.value = value;
        }
        public override int Interpreter()
        {
            return this.value;
        }
    }
}
