using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Meal A = MealBuilder.PrepareSetMenuA();
            Meal B = MealBuilder.PrepareSetMenuB();
            Console.WriteLine("SetMenu A costs :"+A.Cost());
            A.Show();
            Console.WriteLine("SetMenu B costs :"+B.Cost());
            B.Show();
        }
    }
}
