using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class ShapeMaker
    {
        private Circle circle;
        private Square square;
        private Rectangle rectangle;

        public ShapeMaker()
        {
            circle = new Circle();
            square = new Square();
            rectangle = new Rectangle();
        }

        public void DrawCircle()
        {
            circle.Draw();
        }

        public void DrawSquare()
        {
            square.Draw();
        }

        public void DrawRectangle()
        {
            rectangle.Draw();
        }
    }
}
