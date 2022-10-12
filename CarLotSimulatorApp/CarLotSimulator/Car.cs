using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.NumberOfCars++;
        }



        //Create a seperate class file called Car - Done
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - Done
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() - Done
        //The methods should take one string parameter: the respective noise property - Done

        //*************BONUS*************//

        // Set the properties utilizing the 3 different ways we learned about, one way for each car


        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

            public int Year { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public string EngineNoise { get; set; }
            public string HonkNoise { get; set; }
            public bool IsDriveable { get; set; }

            public void MakeEngineNoise(string EngineNoise)
            {
                Console.WriteLine(EngineNoise);
            }

            public void MakeHonkNoise(string honk)
            {
                Console.WriteLine(honk);
            }
        
    }
}

