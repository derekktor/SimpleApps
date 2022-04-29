using System;
using System.IO;

namespace PermutationCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string Domain = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "/inputs";
            string FileCat = "/incorrect";
            string FileName = "/no-perm-1-3.txt";

            string[] input = GetLines(Domain, FileCat, FileName);

            int[] numbers = GetNumbers(input);

            bool hasPermutation = CheckPermutation(numbers);

            Console.WriteLine(hasPermutation);
         
            
        }

        public static bool CheckPermutation(int[] numbers)
        {
            int score = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1] - 1)
                {
                    score++;
                }
            }

            if (score == numbers.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int[] GetNumbers(string[] input)
        {
            bool validN = int.TryParse(input[0], out int n);

            int[] numbers = new int[n];
            string[] texts = input[1].Split(" ");

            if (!validN || texts.Length != n)
            {
                throw new Exception("Invalid n!");
            }

            int index = 0;
            foreach (string num in texts)
            {
                bool isValidNum = int.TryParse(num, out int numInList);
                numbers[index++] = numInList;
            }

            return numbers;
        }

        public static string[] GetLines(string Domain, string FileCat, string FileName)
        {
            string FilePath = Domain + FileCat + FileName;
            return File.ReadAllLines(FilePath);
        }


    }
}
