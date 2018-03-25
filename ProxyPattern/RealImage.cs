using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class RealImage : IImage
    {
        private string _fileName;
        public string FileName
        {
            get => _fileName;
            set
            {
                _fileName = value;
                Console.WriteLine("loading:" + _fileName);
            }
        }
        public void Display()
        {
            Console.WriteLine("display:" + FileName);
        }
    }
}
