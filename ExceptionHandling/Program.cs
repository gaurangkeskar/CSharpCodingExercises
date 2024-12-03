namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HandleMultipleExceptions("1", 1);
            HandleMultipleExceptions("a", 1);
            HandleMultipleExceptions("1", 3);
            Console.ReadKey();
        }

        public static void HandleMultipleExceptions(string str, int num)
        {
            int[] numbers = { 1, 2, 3 };
            try
            {
                int number = int.Parse(str);
                int indexedVal = numbers[num];
                Console.WriteLine(indexedVal);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid format.");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of range.");
            }
        }
    }
}