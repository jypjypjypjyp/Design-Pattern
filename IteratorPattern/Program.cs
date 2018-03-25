using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            NameRepository nameRepository = new NameRepository();
            IIterator iter = nameRepository.Iterator();
            while (iter.HasNext())
            {
                Console.WriteLine((string)iter.Next());
            }
        }
    }
}
