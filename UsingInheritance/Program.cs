namespace UsingInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.makeSound();
        }
        public class Animal
        {
            // TODO: Declare a virtual method MakeSound
            virtual public void makeSound()
            {
                Console.WriteLine("Animal sound");
            }
        }

        public class Dog : Animal
        {
            // TODO: Override the MakeSound method
            public override void makeSound()
            {
                base.makeSound();
                Console.WriteLine("Dog barks");
            }
        }
    }
}