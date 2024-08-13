using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inheritance
{
    internal class Student:Person
    {
        public int SId { get; set; }
        public Student() {
            WriteLine($"Calling constructor Student()");
        }

        public Student(int sID, string fName, string lName, int age): base(fName, lName, age)
        {
            SId = sID;
            
            WriteLine($"Calling constructor Student(int sID, string fName, string lName, int age): base(fName, lName, age)");
        }

        //public Student(int sID, string fName, string lName, int age)
        //{
        //    SId = sID;
        //    FirstName = fName;
        //    LastName = lName;
        //    Age = age;
        //}
    }
}
