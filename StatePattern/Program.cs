using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            StartState start = new StartState();
            start.Do(context);
            Console.WriteLine(context.state);
            StopState stop = new StopState();
            stop.Do(context);
            Console.WriteLine(context.state);
        }
    }
}
