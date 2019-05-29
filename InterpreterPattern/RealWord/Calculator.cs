using InterpreterPattern.RealWord.Expressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.RealWord
{
    public class Calculator
    {
        private string statement;

        private Stack<Expression> expressions = new Stack<Expression>();

        public Calculator(string statement)
        {
            this.statement = statement;
        }

        public int Calc()
        {
            string[] parts = statement.Split(" ");

            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i] == "+")
                {
                    var left = expressions.Pop();
                    var right = new ValueExpression(int.Parse(parts[++i]));
                    expressions.Push(new AddExpression(left, right));
                }
                else if (parts[i] == "-")
                {
                    var left = expressions.Pop();
                    var right = new ValueExpression(int.Parse(parts[++i]));
                    expressions.Push(new SubExpression(left, right));
                }
                else
                {
                    expressions.Push(new ValueExpression(int.Parse(parts[i])));
                }
            }

            var exp = expressions.Pop();

            return exp.Interpreter();
        }
    }
}
