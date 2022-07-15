using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.CarCount++;
        }

        public Car(int year,string make,string model,string engineNoise,string hornNoise,bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HornNoise = hornNoise;
            IsDriveable = isDrivable;
            CarLot.CarCount++;
        }
        public int Year { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HornNoise { get; set; }

        public bool IsDriveable { get; set; }

        public string Make { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHornNoise()
        {
            Console.WriteLine(HornNoise);
        }

    }
}