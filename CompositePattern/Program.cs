using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee CEO = new Employee("John", "CEO", 30000);
            Employee headSales = new Employee("Robert", "Head Sales", 20000);
            Employee headMarketing = new Employee("Michel", "Head Marketing", 20000);
            Employee clerk1 = new Employee("Laura", "Marketing", 10000);
            Employee clerk2 = new Employee("Bob", "Marketing", 10000);
            Employee salesExecutive1 = new Employee("Richard", "Sales", 10000);
            Employee salesExecutive2 = new Employee("Rob", "Sales", 10000);
            CEO.Subordinates.Add(headSales);
            CEO.Subordinates.Add(headMarketing);
            headSales.Subordinates.Add(salesExecutive1);
            headSales.Subordinates.Add(salesExecutive2);
            headMarketing.Subordinates.Add(clerk1);
            headMarketing.Subordinates.Add(clerk2);
            Print(CEO);
        }

        public static void Print(Employee employee)
        {
            Console.WriteLine(employee);
            if (employee.Subordinates.Any())
            {
                foreach(var i in employee.Subordinates)
                {
                    Print(i);
                }
            }
        }
    }
}
