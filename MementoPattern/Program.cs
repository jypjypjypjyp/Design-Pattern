using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();
            originator.State = "state 加载";
            careTaker.List.Add(originator.Save());
            originator.State = "state 初始化";
            careTaker.List.Add(originator.Save());
            originator.State = "state 就绪";
            careTaker.List.Add(originator.Save());
            originator.State = "state 运行";
            careTaker.List.Add(originator.Save());
            originator.State = "state 结束";
            careTaker.List.Add(originator.Save());
            Console.WriteLine("Current State:" + originator.State);
            originator.LoadSave(careTaker.List[0]);
            Console.WriteLine("Current State:" + originator.State);
            originator.LoadSave(careTaker.List[1]);
            Console.WriteLine("Current State:" + originator.State);
            originator.LoadSave(careTaker.List[2]);
            Console.WriteLine("Current State:" + originator.State);
            originator.LoadSave(careTaker.List[3]);
            Console.WriteLine("Current State:" + originator.State);
            originator.LoadSave(careTaker.List[4]);
            Console.WriteLine("Current State:" + originator.State);


        }
    }
}
