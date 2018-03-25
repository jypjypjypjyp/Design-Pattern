using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IImage image = new ProxyImage() { FileName = "filename.jpg" };
            image.Display();
        }
    }
}
