using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Rectangle : ShapePrototype
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle(double h,double w):base()
        {
            Type = "Rectangle";
            Height = h;
            Width = w;
        }

        public override object Clone()
        {
            return new Rectangle(Height, Width);
        }

        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle!!! area="+Height*Width);
        }

        public Rectangle Constructor(double h, double w)
        {
            Height = h;
            Width = w;
            return this;
        }
    }
}
