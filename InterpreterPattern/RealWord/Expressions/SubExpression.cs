using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.RealWord.Expressions
{
    public class SubExpression : Expression
    {
        private Expression left;
        private Expression right;

        public SubExpression(Expression left, Expression right)
        {
            this.left = left;
            this.right = right;
        }
        public override int Interpreter()
        {
            return this.left.Interpreter() - this.right.Interpreter();
        }
    }
}
