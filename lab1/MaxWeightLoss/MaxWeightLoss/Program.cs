using System;
using System.IO;

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


        }

        public static bool DoLinesMatch()

        public static string[] GetLines(string Domain, string FileCat, string FileName)
        {
            string FilePath = Domain + FileCat + FileName;
            return File.ReadAllLines(FilePath);
        }
    }
}
