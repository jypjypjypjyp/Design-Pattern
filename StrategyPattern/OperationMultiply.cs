﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class OperationMultiply : IStrategy
    {
        public int Do(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
