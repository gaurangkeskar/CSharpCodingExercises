namespace AverageTemperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temperatures = { 10, 11, 12, 13, 14, 15 };
            PrintAverage(temperatures);
            Console.ReadKey();
        }

        public static void PrintAverage(double[] temperatures)
        {
            // TODO
            Console.WriteLine("The average temperature is: " + CalculateAverage(temperatures));
        }

        public static double CalculateAverage(double[] temperatures)
        {
            // TODO
            double sum = 0.0;

            foreach (double temp in temperatures)
            {
                sum += temp;
            }

            return sum / temperatures.Length;
        }
    }
}
