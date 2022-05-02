using System;
namespace Animals
{
    public class Animal
    {
        public virtual int Weight { get; set; }
        public virtual double WaterDrank { get; set; }
        public virtual int HayEaten { get; set; }

        public Animal(int weight)
        {
            Weight = weight;
            WaterDrank = 0;
            HayEaten = 0;
        }

        public virtual void DrinkWater()
        {
            Console.WriteLine("{animal} is drinking {waterAmount}L of water...");
        }

        public virtual void Eat()
        {
            Console.WriteLine("{animal} is eating {hayAmount} units of hay...");
        }

        public override string ToString()
        {
            return Weight + "kg, " + WaterDrank + "L, " + HayEaten + " units";
        }
    }
}
