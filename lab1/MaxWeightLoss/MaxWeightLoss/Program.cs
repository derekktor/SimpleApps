using System;
using System.IO;
using System.Diagnostics;

namespace MaxWeightLoss
{
    class Program
    {
        static void Main(string[] args)
        {
            string Domain = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string FileCat = "/inputs";
            string FileName = "/three2.txt";

            string[] input = GetLines(Domain, FileCat, FileName);

            int days = GetNumberOfDays(input[0]);
            int[] weights = GetWeights(input[1]);

            Debug.Assert(days == weights.Length, "Days and number of weights written don't match!");

            WeightTracker wt = new WeightTracker(weights);

            wt.GetInfo();

            int maxDiff = wt.GetMaxDiff();

            Console.WriteLine(maxDiff);

        }

        public static int[] GetWeights(string line)
        {
            string[] textNums = line.Split(" ");
            int[] weights = new int[textNums.Length];

            for (int i = 0; i < weights.Length; i++)
            {
                bool isWeightValid = int.TryParse(textNums[i], out int w);
                Debug.Assert(isWeightValid == true, "Weight has to be a number!");
                weights[i] = w;
            }
            return weights;
        }

        public static int GetNumberOfDays(string FirstLine)
        {
            bool isDaysValid = int.TryParse(FirstLine, out int days);
            Debug.Assert(isDaysValid == true, "First line has to be a number!");
            return days;
        }

        //public static bool DoLinesMatch()

        public static string[] GetLines(string Domain, string FileCat, string FileName)
        {
            string FilePath = Domain + FileCat + FileName;
            return File.ReadAllLines(FilePath);
        }
    }
}
