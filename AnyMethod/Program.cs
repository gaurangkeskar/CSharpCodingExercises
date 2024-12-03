namespace UsingAnyMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myNumbers = new List<int> { 1, 6, 3 };
            bool myBool = myNumbers.Any(x => x > 5);
            Console.WriteLine(myBool);
            Console.ReadKey();
        }
    }
}