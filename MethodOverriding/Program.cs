namespace MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.makeSound();
            Dog dog = new Dog();
            dog.makeSound();
            Cat cat = new Cat();
            cat.makeSound();
            Console.ReadKey();
        }
    }

    public class Animal
    {
        virtual public void makeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    public class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    public class Cat : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }
}

