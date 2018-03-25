using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class NameRepository : IContainer
    {
        public string[] items = { "Robert", "John", "Julie", "Lora" };


        public IIterator Iterator()
        {
            return new NameIterator(this);
        }

        private class NameIterator : IIterator
        {
            int index;
            private NameRepository outer;
            public NameIterator(NameRepository o) => outer = o;
            public bool HasNext()
            {
                if (index < outer.items.Length)
                {
                    return true;
                }
                return false;
            }

            public object Next()
            {
                if (HasNext())
                {
                    return outer.items[index++];
                }
                return null;
            }
        }
    }
}
