namespace StaticMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoubleValue(10));
            Console.ReadKey();
        }
        public static int DoubleValue(int number)
        {
            // TODO: Implement the method to double the value
            return number * 2;
        }
    }
}
