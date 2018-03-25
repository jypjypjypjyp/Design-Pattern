using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class RedCircle : IDraw
    {
        public void DrawCircle(double r, double x, double y)
        {
            Console.WriteLine("draw a red circle:" + r + "," + x + "," + y);
        }
    }
}
