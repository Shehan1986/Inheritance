using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inheritance
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        private static int Instantcount { get; set; } = 0;
        
        public Person()
        {
            WriteLine("Person(1)");
           

            IncreaceInsntantCount();
        }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            WriteLine("Person(2)");
            IncreaceInsntantCount();
        }

        public void Introduce()
        { 
            WriteLine($"Hi! I am {FirstName} {LastName}");
        }

        private void IncreaceInsntantCount()
        { 
            Instantcount++;
        }

        public static int GetInstanceCount()
        { 
            return Instantcount;
        }
    }
}
