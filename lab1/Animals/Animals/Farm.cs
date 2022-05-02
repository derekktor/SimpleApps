using System;
using System.Collections.Generic;
namespace Animals
{
    public class Farm
    {
        public List<Animal> animals { get; set; }
        public double TotalWaterDrank;
        public int TotalHayEaten;

        public Farm()
        {
            animals = new List<Animal>();
            TotalHayEaten = 0;
            TotalWaterDrank = 0;
        }

        public void FeedAnimals()
        {
            foreach (var animal in animals)
            {
                animal.Eat();
                TotalHayEaten += animal.HayEaten;
            }
        }

        public void WaterAnimals()
        {
            foreach (var animal in animals)
            {
                animal.DrinkWater();
                TotalWaterDrank += animal.WaterDrank;
            }
        }

        public void ShowAnimals()
        {
            foreach (var animal in animals)
            {
                Console.Write(animal.ToString() + "\n");
            }
            Console.WriteLine();
        }

        public void ShowInventory()
        {
            Console.Write("Water:\t" + TotalWaterDrank + "\n");
            Console.Write("Hay:\t" + TotalHayEaten + "\n");
            Console.WriteLine();
        }

        public Animal GetLightestAnimal()
        {
            Animal lightestAnimal = new Animal(1000);

            foreach (var animal in animals)
            {
                if (animal.Weight < lightestAnimal.Weight)
                {
                    lightestAnimal = animal;
                }
            }

            return lightestAnimal;
        }
    }
}
