using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class ComputerPartDisplayVisitor : IComputerPartVisitor
    {
        public void Visit(Computer computer)
        {
            Console.WriteLine("Display:Computer");
        }

        public void Visit(Mouse mouse)
        {
            Console.WriteLine("Display:Mouse");
        }

        public void Visit(Keyboard keyboard)
        {
            Console.WriteLine("Display:Keyboard");
        }

        public void Visit(Monitor monitor)
        {
            Console.WriteLine("Display:Monitor");
        }
    }
}
