using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class Program
    {
        public static readonly string[] Colors = { "red", "green", "blue" };

        static void Main(string[] args)
        {
            Random rd = new Random();
            for(int i = 0; i < 20; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetCircle(Colors[rd.Next(3)]);
                circle.X = rd.Next(1000);
                circle.Y = rd.Next(1000);
                circle.R = rd.Next(300);
                circle.Draw();
            }
        }


    }
}
