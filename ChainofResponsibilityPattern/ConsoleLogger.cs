using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityPattern
{
    class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(int l)
        {
            level = l;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("Console:" + message);
        }
    }
}
