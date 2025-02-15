﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarLotSimulator
{
    public class Car
    {
        public Car() 
        {
            Carlot.numberOfCars++;
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(HonkNoise);
        }

        public void DriveablePrinter(bool  isDrivable)
        {
            if (isDrivable == true)
            {
                Console.WriteLine("This vehicle is able to be driven off the lot today!");
            }
            else
            {
                Console.WriteLine("This vehicle will require a bit of maintenance before it's ready for the roads.");
            }

        }
    }


}


