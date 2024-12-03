namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCardPayment c = new CreditCardPayment();
            c.ProcessPayment();
            PayPalPayment p = new PayPalPayment();
            p.ProcessPayment();
            Console.ReadKey();
        }
        public interface IPayment
        {
            // TODO: Declare a method ProcessPayment
            void ProcessPayment();
        }

        public class CreditCardPayment : IPayment
        {
            // TODO: Implement the ProcessPayment method
            public void ProcessPayment()
            {
                Console.WriteLine("Processing credit card payment");
            }
        }

        public class PayPalPayment : IPayment
        {
            // TODO: Implement the ProcessPayment method
            public void ProcessPayment()
            {
                Console.WriteLine("Processing PayPal payment");
            }
        }
    }
}