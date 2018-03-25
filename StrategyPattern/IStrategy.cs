using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    interface IStrategy
    {
        int Do(int num1, int num2);
    }
}
