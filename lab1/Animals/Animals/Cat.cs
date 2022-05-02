using System;
namespace Animals
{
    public class Cat: Animal
    {
        public override int Weight { get; set; }
        public override double WaterDrank { get; set; }

        public Cat(int weight): base(weight)
        {
        }

        public override void DrinkWater()
        {
            string animal = "Cat";
            double waterAmount = 0.5;
            WaterDrank += waterAmount;
            Console.WriteLine($"{animal} is drinking {waterAmount}L of water...");
        }

        public override void Eat()
        {
            Console.WriteLine("Cat is eating anything but hay...");   
        }

        public override string ToString()
        {
            return "Cat\n\t" + base.ToString();
        }
    }
}
