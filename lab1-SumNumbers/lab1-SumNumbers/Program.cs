using System;

namespace lab1_SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNumbers numbers = new MyNumbers();

            Console.WriteLine("Enter list of positive numbers!!!");

            string userInput = "";

            bool finished = false;

            while (!finished)
            {
                userInput = Console.ReadLine();
                finished = !int.TryParse(userInput, out int result);
                numbers.add(result);
            }

            Console.WriteLine(numbers.getInfo());
            

        }
    }
}
