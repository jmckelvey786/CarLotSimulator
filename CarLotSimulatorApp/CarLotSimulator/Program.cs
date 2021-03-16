using System;

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

            Car car1 = new Car("Ford", "Fiesta", 2011);
            car1.MakeEngineNoise("Vroom");
            car1.MakeHonkNoise("Beeep beep!");
            car1.WhatIsThatIHear();

            Car car2 = new Car("Volkswagon", "Tiguan", 2017);
            car2.MakeEngineNoise("Zoom Zoom");
            car2.MakeHonkNoise("Honk hooonnnkk");
            car2.WhatIsThatIHear();

            Car car3 = new Car("Ford", "F150", 2019);
            car3.MakeEngineNoise("Chug chug chug");
            car3.MakeHonkNoise("bonk bonk!");
            car3.WhatIsThatIHear();


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
