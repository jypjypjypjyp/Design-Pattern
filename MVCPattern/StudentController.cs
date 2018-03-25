using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern
{
    class StudentController
    {
        public Student Model { get; set; }
        public StudentView View;
        public void UpdateView()
        {
            View.Print(Model.Name, Model.RollNo);
        }
    }
}
