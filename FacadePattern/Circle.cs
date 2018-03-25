using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("draw a circle.");
        }
    }
}
