namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator();
            Console.ReadKey();
        }
        public static void SimpleCalculator()
        {
            // TODO: Implement the calculator logic here
            Console.WriteLine("Enter the first number:");
            int number1;
            Int32.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Enter the second number:");
            int number2;
            Int32.TryParse(Console.ReadLine(), out number2);
            Console.WriteLine("Choose an operation: +, -, *, /");
            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case '+':
                    Console.WriteLine("Result: " + (number1 + number2));
                    break;
                case '-':
                    Console.WriteLine("Result: " + (number1 - number2));
                    break;
                case '*':
                    Console.WriteLine("Result: " + (number1 * number2));
                    break;
                case '/':
                    if (number2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        Console.WriteLine("Result: " + (number1 / number2));
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                    break;
            }
        }
    }
}
