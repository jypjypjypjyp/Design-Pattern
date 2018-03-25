using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class Circle : IShape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }
        public int R { get; set; }

        public void Draw()
        {
            Console.WriteLine("Circle:" + X + "," + Y + "," + R + "," + Color + ";");
        }
    }
}
