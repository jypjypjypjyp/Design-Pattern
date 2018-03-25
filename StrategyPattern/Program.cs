using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new OperationAdd());
            Console.WriteLine("10+5=" + context.Execute(10, 5));
            context = new Context(new OperationSubstract());
            Console.WriteLine("10-5=" + context.Execute(10, 5));
            context = new Context(new OperationMultiply());
            Console.WriteLine("10*5=" + context.Execute(10, 5));

        }
    }
}
