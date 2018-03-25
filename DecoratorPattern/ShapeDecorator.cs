using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    abstract class ShapeDecorator : IShape
    {
        protected IShape shape;
        public ShapeDecorator(IShape s)
        {
            shape = s;
        }
        public virtual void Draw()
        {
            shape.Draw();
        }
    }
}
