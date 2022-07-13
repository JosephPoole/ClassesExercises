using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListOfCars = new List<Car>();

            //TODO
            //Now that the Car class is created we can instanciate 3 new cars
            Car car1 = new Car();
            // 
            Car car2 = new Car() 
            { Year = 2019, 
              Make = "Audi",
              Model = "R8", 
              EngineNoise = "None",
              HonkNoise = "Beep", 
              IsDriveable = true};
            Car car3 = new Car(2018,"Chevrolet","Silverado","none","beep",false);
            //Set the properties for each of the cars
            car1.Year = (2022);
            car1.Make = "Ford";
            car1.Model = "Bronco";
            car1.EngineNoise = "none";
            car1.HonkNoise = "boop";
            car1.IsDriveable = true;

            //Call each of the methods for each car
            Console.WriteLine($"The {car1.Year} {car1.Make} {car1.Model}");
            Console.WriteLine("Makes a ");
            car1.MakeEngineNoise("low Rumble");
            Console.WriteLine("When the engines running.");
            Console.WriteLine("It's horn sounds like");
            car1.MakeHonkNoise("beep");
            Console.WriteLine();
            Console.WriteLine($"The {car2.Year} {car2.Make} {car2.Model}");
            Console.WriteLine("Makes a ");
            car2.MakeEngineNoise("purring sound");
            Console.WriteLine("When the engines running.");
            Console.WriteLine("It's horn sounds like");
            car2.MakeHonkNoise("boop");
            Console.WriteLine();
            Console.WriteLine($"The {car3.Year} {car3.Make} {car3.Model}");
            Console.WriteLine("Makes a ");
            car3.MakeEngineNoise("growling sound");
            Console.WriteLine("When the engines running.");
            Console.WriteLine("It's horn sounds like");
            car3.MakeHonkNoise("meep");
            Console.WriteLine();

            ListOfCars.Add(car1);
            ListOfCars.Add(car2);
            ListOfCars.Add(car3);
            Console.WriteLine($"The List is Comprised of the following cars \n" +
                $"{car1.Year} {car1.Make} {car1.Model} \n" +
                $"{car2.Year} {car2.Make} {car2.Model} \n" +
                $"{car3.Year} {car3.Make} {car3.Model}");


           
        }
    }
}
