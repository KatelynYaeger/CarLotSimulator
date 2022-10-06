using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //Now that the Car class is created we can instanciate 3 new cars - Done
            //Set the properties for each of the cars - Done
            //Call each of the methods for each car - Done
            //Instanciate Carlot at the beginning of the program and as you
            //create a car add the car to the list.

            var lot = new CarLot();

            var katelynsCar = new Car();
            katelynsCar.Year = 1986;
            katelynsCar.Make = "VW";
            katelynsCar.Model = "Cabriolet";
            katelynsCar.EngineNoise = "Vroom";
            katelynsCar.HonkNoise = "Squeak";
            katelynsCar.IsDriveable = true;


            var familyCar = new Car(2001, "Honda", "Civic", "Crunch", "Beep", false);

            var fixerUpper = new Car()

            {
                Year = 2018,
                Make = "VW",
                Model = "Beetle",
                EngineNoise = "GRRRR",
                HonkNoise = "Meep",
                IsDriveable = false

            };


            katelynsCar.MakeEngineNoise(katelynsCar.EngineNoise);
            katelynsCar.MakeHonkNoise(katelynsCar.HonkNoise);

            familyCar.MakeEngineNoise(familyCar.EngineNoise);
            familyCar.MakeHonkNoise(familyCar.HonkNoise);

            fixerUpper.MakeEngineNoise(fixerUpper.EngineNoise);
            fixerUpper.MakeHonkNoise(fixerUpper.HonkNoise);

            lot.Cars.Add(katelynsCar);
            lot.Cars.Add(fixerUpper);
            lot.Cars.Add(familyCar);

            foreach (var vehicle in lot.Cars)
            {
                Console.WriteLine($"Year: {vehicle.Year} Make: {vehicle.Make} and Model: {vehicle.Model}");
            }



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car - Done

            //*************BONUS X 2*************//

            //Create a CarLot class - Done
            //It should have at least one property: a List of cars - Done
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list - Done
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console - Done
        }
    }
}
