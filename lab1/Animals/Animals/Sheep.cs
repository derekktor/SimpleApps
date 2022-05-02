using System;
namespace Animals
{
    public class Sheep: Animal
    {
        public override int Weight { get; set; }
        public override double WaterDrank { get; set; }
        public override int HayEaten { get; set; }

        public Sheep(int weight): base(weight)
        {
        }

        public override void DrinkWater()
        {
            string animal = "Sheep";
            double waterAmount = 2;
            WaterDrank += waterAmount;
            Console.WriteLine($"{animal} is drinking {waterAmount}L of water...");
        }

        public override void Eat()
        {
            string animal = "Sheep";
            int hayAmount = 40;
            HayEaten += hayAmount;
            Console.WriteLine($"{animal} is eating {hayAmount} units of hay...");
        }

        public override string ToString()
        {
            return "Sheep\n\t" + base.ToString();
        }
    }
}
