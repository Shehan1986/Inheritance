using static System.Console;
namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //  ClassA obj = new ClassA();



            Person p1 = new Person();
            WriteLine($"Total object are:  { Person.GetInstanceCount()}");

            Person p2 = new Person("Shehan","Perera", 20); 
            Person p3 = new Person("Saman", "Silva", 60); 
            Person p4 = new Person("Oleen", "Perera", 70);

            WriteLine($"Total object are:  {Person.GetInstanceCount()}");


            Student s1 = new Student();
            Student s2 = new Student(1, "Shehan","Perera", 19);

            WriteLine($"Total object are:  {Person.GetInstanceCount()}");

            ReadKey();
        }
    }
}
