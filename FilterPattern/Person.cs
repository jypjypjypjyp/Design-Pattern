using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern
{
    class Person
    {
        public string Name { get; }
        public string Gender { get; }
        public string MaritalStatus { get; }

        public Person(string n,string g,string m)
        {
            Name = n;
            Gender = g;
            MaritalStatus = m;
        }

        public override string ToString()
        {
            return ""+Name+"("+Gender+"):"+MaritalStatus+".";
        }
    }
}
