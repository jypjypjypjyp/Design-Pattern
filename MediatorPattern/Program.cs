using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            User robert = new User() { Name = "Robert" };
            User john = new User() { Name = "John" };
            robert.SendMessage("Hi! John!");
            john.SendMessage("你好");
            Console.WriteLine("阿大撒大撒");
        }
    }
}
