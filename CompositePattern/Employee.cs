using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Employee
    {
        public string Name { get; set; }
        public string Dept { get; set; }
        public int Salary { get; set; }
        public List<Employee> Subordinates;

        public Employee(string n,string d,int s)
        {
            Name = n;
            Dept = d;
            Salary = s;
            Subordinates = new List<Employee>();
        }

        public override string ToString()
        {
            return "Employee:[Name:" + Name + ",Dept:" + Dept + ",Salary:" + Salary + "]";
        }
    }
}
