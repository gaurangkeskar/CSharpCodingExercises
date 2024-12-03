namespace ClassProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Gaurang", 24);
            person.Greet();
            Console.ReadKey();
        }
    }

    public class Person
    {
        // TODO
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        private int _age;
        public int Age { get { return _age; } set { _age = value; } }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {_name} and I am {_age} years old.");
        }
    }
}