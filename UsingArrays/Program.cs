namespace UsingArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers();
            Console.ReadKey();
        }
        public static void PrintNumbers()
        {
            // Initialize array and print each number using a foreach loop
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }

    }
}
