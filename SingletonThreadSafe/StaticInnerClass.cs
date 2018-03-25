using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonThreadSafe
{
    public class StaticInnerClass
    {
        private static class SingletonHolder
        {
            public static readonly StaticInnerClass _instance = new StaticInnerClass();
        }
        public static StaticInnerClass GetInstance()
        {
            return SingletonHolder._instance;
        }
    }
}
