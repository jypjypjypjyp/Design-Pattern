using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonThreadSafe
{
    public class DCL
    {
        private volatile static DCL _instance;
        private DCL() { }
        public static DCL GetInstance()
        {
            if(_instance == null)
            {
                lock (_instance)
                {
                    if (_instance == null)
                        _instance = new DCL();
                }
            }
            return _instance;
        }
        public void Function()
        {
            Console.WriteLine("Hello World!!!");
        }
    }
}
