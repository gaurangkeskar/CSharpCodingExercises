﻿namespace UsingInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Drive();
            Console.ReadKey();
        }

        public interface IVehicle
        {
            // TODO: Declare a method Drive
            void Drive();
        }

        public class Car : IVehicle
        {
            // TODO: Implement the Drive method
            public void Drive()
            {
                Console.WriteLine("Car is driving");
            }
        }
    }
}