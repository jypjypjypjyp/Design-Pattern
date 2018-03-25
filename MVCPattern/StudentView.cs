using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern
{
    class StudentView
    {
        public void Print(string name,string rollno)
        {
            Console.WriteLine("Student:");
            Console.WriteLine("Name:"+name);
            Console.WriteLine("RollNo:"+rollno);
        }
    }
}
