using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Meal
    {
        public List<IItem> ItemList = new List<IItem>();

        public decimal Cost()
        {
            decimal sum = 0m;
            foreach (var i in ItemList)
            {
                sum += i.Price();
            }
            return sum;
        }
        public void Show()
        {
            foreach (var i in ItemList)
            {
                Console.WriteLine(i.Name());
            }
        }
    }
}
