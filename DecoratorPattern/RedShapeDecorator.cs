using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape s) : base(s)
        {
        }

        public override void Draw()
        {
            base.Draw();
            SetRedBorder(shape);
        }

        public void SetRedBorder(IShape shape)
        {
            Console.WriteLine("Border Color:Red");
        }
    }
}
