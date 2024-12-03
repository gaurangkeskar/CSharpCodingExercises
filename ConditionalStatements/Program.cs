namespace ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckLogin();
            Console.ReadKey();
        }
        public static void CheckLogin()
        {
            bool isLoggedIn = false;

            if (isLoggedIn)
            {
                Console.WriteLine("Welcome back!");
            }
            else
            {
                Console.WriteLine("Please log in.");
            }
        }
    }
}
