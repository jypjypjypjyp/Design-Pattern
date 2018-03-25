using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class GreenCircle : IDraw
    {
        public void DrawCircle(double r, double x, double y)
        {
            Console.WriteLine("draw a green circle" + r + "," + x + "," + y);
        }
    }
}
