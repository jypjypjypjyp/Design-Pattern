using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class AndExpression : IExpression
    {
        private IExpression expr1 = null;
        private IExpression expr2 = null;
        public AndExpression(IExpression e1, IExpression e2)
        {
            expr1 = e1;
            expr2 = e2;
        }
        public bool Interpret(string context)
        {
            return expr1.Interpret(context) && expr2.Interpret(context);
        }
    }
}
