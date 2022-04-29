using System;

namespace lab1_LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isLeapYear;
            bool wantAgain = true;

            while (wantAgain)
            {
                Console.WriteLine("Enter a year:");

                int userInput = int.Parse(Console.ReadLine());

                if (userInput % 4 == 0)
                {
                    isLeapYear = true;
                }
                else
                {
                    isLeapYear = false;
                }

                if (isLeapYear)
                {
                    Console.WriteLine($"{userInput} is a leap year");
                }
                else
                {
                    Console.WriteLine($"{userInput} is a NOT A FUCKING leap year");
                }

                Console.WriteLine("Want to try another year?");

                string answer = Console.ReadLine().ToLower();

                if (answer.Equals("yes") || answer.Equals("yeah"))
                {
                    wantAgain = true;
                } else
                {
                    wantAgain = false;
                    Console.WriteLine("FUCK OFF CUNT!!!");
                }

            }

            

        }
    }
}
