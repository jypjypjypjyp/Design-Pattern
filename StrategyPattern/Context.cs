using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Context
    {
        private IStrategy strategy;
        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }
        public int Execute(int num1, int num2)
        {
            return strategy.Do(num1, num2);
        }
    }
}
