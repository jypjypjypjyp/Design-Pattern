using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityPattern
{
    class ErrorLogger : AbstractLogger
    {
        public ErrorLogger(int l)
        {
            level = l;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("Error:" + message);
        }
    }
}
