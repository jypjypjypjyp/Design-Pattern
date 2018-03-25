using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Hamburger : IItem
    {
        public Condiment Condiment { get; set; }

        public virtual string Name() =>(Condiment!=null)?Condiment.Name()+"Hamburger":"Hamnurger";

        public virtual decimal Price() => (Condiment!=null)?30.0m+Condiment.Price():30.0m;
    }
}
