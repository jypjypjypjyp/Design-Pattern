using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class MealBuilder
    {
        public static Meal PrepareSetMenuA()
        {
            Meal newMeal = new Meal();
            newMeal.ItemList.Add(new ChickenHamburger() { Condiment = new SweetCondiment() });
            return newMeal;
        }

        public static Meal PrepareSetMenuB()
        {
            Meal newMeal = new Meal();
            newMeal.ItemList.Add(new BeefHamburger() { Condiment = new HotCondiment() });
            newMeal.ItemList.Add(new ChickenHamburger() { Condiment = new SweetCondiment() });
            return newMeal;
        }
    }
}
