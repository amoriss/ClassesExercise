using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    class Car
           
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car()
        {

        }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            //Console.WriteLine($"Make: {Make}. Model: { Model} . Year {Year}");
            PrintCars();
        }

        public void PrintCars()
        {
            Console.WriteLine($"Make: {Make}. Model: { Model} . Year {Year}");
        }

        /* Create a Make property of type string that is public
Create a Model property of type string that is public
Create a Year property of type int that is public */ 
     




    }
}
