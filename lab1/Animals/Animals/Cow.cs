using System;
namespace Animals
{
    public class Cow: Animal
    {
        public override int Weight { get; set; }
        public override double WaterDrank { get; set; }
        public override int HayEaten { get; set; }

        public Cow(int weight): base(weight)
        {
        }

        public override void DrinkWater()
        {
            string animal = "Cow";
            double waterAmount = 3;
            WaterDrank += waterAmount;
            Console.WriteLine($"{animal} is drinking {waterAmount}L of water...");
        }

        public override void Eat()
        {
            string animal = "Cow";
            int hayAmount = 80;
            HayEaten += hayAmount;
            Console.WriteLine($"{animal} is eating {hayAmount} units of hay...");
        }

        public override string ToString()
        {
            return "Cow\n\t" + base.ToString();
        }
    }
}
