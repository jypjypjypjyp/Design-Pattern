using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class ShapeFactory
    {
        private static readonly Dictionary<string, IShape> Map = new Dictionary<string, IShape>();

        public static IShape GetCircle(string color)
        {
            Circle circle;
            try { circle = (Circle)Map[color]; }
            catch
            {
                circle = new Circle() { Color = color };
                Map.Add(color, circle);
                Console.WriteLine("Create new circle");
            }
            return circle;
        }
    }
}
