using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classes Exercise:");
            var firstCar = new Car();
            //Car firstCar = new Car(); //same as above
            firstCar.Make = "Toyota";
            firstCar.Model = "Corolla";
            firstCar.Year = 2003;

            var secondCar = new Car()
            {
                Make = "Mazda",
                Model = "xyz203",
                Year = 2030
            };

            firstCar.PrintCars();
            secondCar.PrintCars();

            var chevy = new Car("Chevy", "Truck", 2010);
            //Console.WriteLine($"chevy")

        }
    }
}
