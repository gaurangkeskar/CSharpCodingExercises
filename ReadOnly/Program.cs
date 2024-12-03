namespace ReadonlyProperty
{
    public class MyClass
    {
        // TODO: Declare a private readonly field to store the value
        // TODO: Create a public read-only property to expose the field's value
        private readonly string _str;

        public string str { get { return _str; } }

        public MyClass(string value)
        {
            // TODO: Initialize the readonly field with the value parameter
            _str = value;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass("Read-Only Property Value");
            Console.WriteLine(myClass.str);
            Console.ReadKey();
        }
    }
}