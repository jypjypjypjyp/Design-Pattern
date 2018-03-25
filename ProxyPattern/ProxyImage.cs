using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class ProxyImage : IImage
    {
        private RealImage image;
        private string _fileName;
        public string FileName
        {
            get => _fileName;
            set
            {
                _fileName = value;
                image = new RealImage() { FileName = _fileName };
            }
        }
        public void Display()
        {
            if (image != null) image.Display();
        }
    }
}
