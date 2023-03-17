﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

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

            // ALEC NOTE VVVVVVVVVVVVVVVVVVV
            // The MakeEngineNoise and MakeHornNoise methods look super awk here, but just trying to follow the spirit of the exercise while getting some more practice in.
            // ALEC NOTE ^^^^^^^^^^^^^^^^^^^


            var lot = new Carlot();

            //Defining and initializing Cars
            var car1 = new Car()
            {
                Make = "Nissan",
                Model = "Murano",
                Year = 2006,
                EngineNoise = "rattley, like all good Nissans are.",
                HonkNoise = "fairly sad honk, more like a meep,",
                IsDrivable = false

            };
            lot.Cars.Add(car1);

            var car2 = new Car();
            car2.Make = "Subaru";
            car2.Model = "WRX";
            car2.Year = 2016;
            car2.EngineNoise = "VROOM.";
            car2.HonkNoise = "ashrill screech,";
            car2.IsDrivable = true;
            lot.Cars.Add(car2);

            var car3 = new Car(2018, "Tesla", "Model 3", "it's a Tesla.", "a standard honk sound.", true);
            lot.Cars.Add(car3);

            //Writeline section
            //////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("Here are the profiles for the vehicles we have on offer.");
            Console.WriteLine("\n");

            //////////////////////////////////////////////////////////////////////////////////////////////
            
            Console.WriteLine($"Firstly, we have a {car1.Year} {car1.Make} {car1.Model}.");
            Console.WriteLine("The engine noise for this vehicle can best be desribed as");
            car1.MakeEngineNoise(car1.EngineNoise);
            Console.WriteLine("and the sound of the horn could be described as");
            car1.MakeHonkNoise(car1.HonkNoise);
            car1.DriveablePrinter(car1.IsDrivable);
            Console.WriteLine("\n");

            //////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine($"Second, we have a {car2.Year} {car2.Make} {car2.Model}.");
            Console.WriteLine("The engine noise for this vehicle can best be desribed as");
            car2.MakeEngineNoise(car2.EngineNoise);
            Console.WriteLine("and the sound of the horn could be described as");
            car2.MakeHonkNoise(car2.HonkNoise);
            car2.DriveablePrinter(car2.IsDrivable);
            Console.WriteLine("\n");

            //////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine($"Lastly, we have a {car3.Year} {car3.Make} {car3.Model}.");
            Console.WriteLine("The engine noise for this vehicle can best be desribed as");
            car3.MakeEngineNoise(car3.EngineNoise);
            Console.WriteLine("and the sound of the horn could be described as");
            car3.MakeHonkNoise(car3.HonkNoise);
            car3.DriveablePrinter(car3.IsDrivable);
            Console.WriteLine("\n");

            //////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("Again, the cars currently on sale are as follows:");
            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model} \n");
            }

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
