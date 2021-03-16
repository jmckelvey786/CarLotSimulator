using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Car
    {
        public string Make;
        public string Model;
        public int Year;

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public void MakeEngineNoise(string noise)
        {
            string Noise = noise;
            Console.WriteLine($"{Noise}");
        }
        public void MakeHonkNoise(string honk)
        {
            string Honk = honk;
            Console.WriteLine($"{Honk}");
        }

        public void WhatIsThatIHear()
        {
            Console.WriteLine($"What is that? It must be {Year} {Make} {Model}!");
        }
    }
}
