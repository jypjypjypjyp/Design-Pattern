using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Circle : Shape
    {
        private double r, x, y;

        public Circle(double r,double x,double y,IDraw d):base(d)
        {
            this.r = r;
            this.x = x;
            this.y = y;
        }

        public override void Draw()
        {
            drawApi.DrawCircle(r, x, y);
        }
    }
}
