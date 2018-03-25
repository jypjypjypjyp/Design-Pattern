using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Circle : ShapePrototype
    {
        public double R { get; set; }
        public Circle(double r) : base()
        {
            R = r;
            Type = "Circle";
        }
        public override object Clone()
        {
            return new Circle(R);
        }

        public override void Draw()
        {
            Console.WriteLine("draw a Circle!!! area=" + 3.14 * R * R);
        }

        public Circle Constructor(double r)
        {
            R = r;
            return this;
        }
    }
}
