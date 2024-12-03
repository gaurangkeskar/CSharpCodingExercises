namespace ConstructorInheritance
{
    internal class Program
    {
        public class Person
        {
            // TODO: Declare a constructor that takes a name and prints a message
            public Person(string name)
            {
                Console.WriteLine($"Person constructor: {name}");
            }
        }

        public class Employee : Person
        {
            // TODO: Declare a constructor that takes a name and an ID, and calls the base class constructor
            public Employee(int id, string name) : base(name)
            {
                Console.WriteLine($"Employee constructor: {name}, ID: {id}");
            }
        }
        static void Main(string[] args)
        {
            Employee person = new Employee(123, "Gaurang");
            Console.ReadKey();
        }
    }
}