namespace UsingDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> keyValuePairs = new Dictionary<string, List<int>>();
            keyValuePairs["first"] = new List<int> { 1, 2, 3 };
            foreach (int num in keyValuePairs["first"])
            {
                Console.Write(num + " ");
            }
            Console.ReadKey();
        }
    }
}