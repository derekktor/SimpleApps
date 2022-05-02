using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(10);
            Cat cat1 = new Cat(1);
            Cow cow = new Cow(200);
            Sheep sheep = new Sheep(140);

            Farm farmA = new Farm();

            farmA.animals.Add(cat);
            farmA.animals.Add(cat1);
            farmA.animals.Add(cow);
            farmA.animals.Add(sheep);

            farmA.FeedAnimals();
            farmA.FeedAnimals();
            farmA.FeedAnimals();
            farmA.WaterAnimals();


            farmA.ShowAnimals();
            farmA.ShowInventory();
            Console.WriteLine(farmA.GetLightestAnimal());
        }
    }
}
