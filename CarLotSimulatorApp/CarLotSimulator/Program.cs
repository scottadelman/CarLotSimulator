using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var CarLot = new CarLot();
            
            var toyota = new Car();
            toyota.Year = 2020;
            toyota.Make = "Toyota";
            toyota.Model = "4Runner";
            toyota.EngineNoise = "Vroom";
            toyota.HornNoise = "Beep";
            toyota.IsDriveable = true;

            var chevy = new Car()
            {
                Year = 2021,
                Make = "Chevrolet",
                Model = "Camaro ZL1",
                EngineNoise = "650HP of Vroom",
                HornNoise = "Beep Beep",
                IsDriveable = true
            };

            Car audi = new Car(2020, "Audi", "R8", "Huge Vroom", "Beep Beep Beep", true);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            CarLot.ParkingLot = new List<Car>() { toyota, chevy, audi }; 
            
            foreach(var car in CarLot.ParkingLot)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
                car.MakeEngineNoise();
                car.MakeHornNoise();
            }
        
        }
    }
}
