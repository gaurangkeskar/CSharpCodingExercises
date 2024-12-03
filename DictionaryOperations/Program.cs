namespace DictionaryOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>
            {
                { "John", new Student(1, "John", 85) },
                { "Alice", new Student(2, "Alice", 90) },
                { "Bob", new Student(3, "Bob", 78) }
            };
            students["John"].display();
            students["Alice"].display();
            students["Bob"].display();
            Console.ReadKey();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public Student(int id, string name, int grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }

        public void display()
        {
            Console.WriteLine($"Name: {Name}, Id: {Id}, Grade: {Grade}");
        }
    }

}