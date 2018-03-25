using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape redCircle = new Circle(100, 10, 2, new RedCircle());
            Shape greenCircle = new Circle(12, 50, 50, new GreenCircle());

            redCircle.Draw();
            greenCircle.Draw();
        }
    }
}
