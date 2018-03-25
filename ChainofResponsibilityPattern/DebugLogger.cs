using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityPattern
{
    class DebugLogger:AbstractLogger
    {
        public DebugLogger(int l)
        {
            level = l;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("Debug:" + message);
        }
    }
}
