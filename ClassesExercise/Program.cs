using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var firstCar = new Car();
            //Car firstCar = new Car(); //same as above
            firstCar.Make = "Toyota";
            firstCar.Model = "Corolla";
            firstCar.Year = 2003;
            Console.WriteLine($"Make: {firstCar.Make}. Model: {firstCar.Model}. Year:{firstCar.Year}");
        }
    }
}
