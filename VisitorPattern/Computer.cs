using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Computer : IComputerPart
    {
        IComputerPart[] parts;
        public Computer()
        {
            parts = new IComputerPart[] {
                new Mouse(),
                new Keyboard(),
                new Monitor()
            };
        }
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            foreach(var i in parts)
            {
                i.Accept(computerPartVisitor);
            }
            computerPartVisitor.Visit(this);
        }
    }
}
