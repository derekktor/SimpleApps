using System;
using System.Collections.Generic;

namespace TextAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<char> letters = new List<char>();
            Dictionary<char, int> lettersDict = new Dictionary<char, int>();

            lettersDict = GetDict(input, letters);
            GetDictInfo(lettersDict);

        }

        public static Dictionary<char, int> GetDict(string input, List<char> letters)
        {
            GetUniqueLetters(input, letters);
            return CountLetters(input, letters);
        }

        public static void GetDictInfo(Dictionary<char, int> lettersDict)
        {
            foreach (var letter in lettersDict)
            {
                Console.WriteLine(letter);
            }
        }

        public static Dictionary<char, int> CountLetters(string input, List<char> letters)
        {
            Dictionary<char, int> lettersDict = new Dictionary<char, int>();

            foreach (char letter in letters)
            {
                int count = 0;
                foreach (char c in input)
                {
                    if (letter == c)
                    {
                        count++;
                    }
                }
                lettersDict.Add(letter, count);
            }

            return lettersDict;
        }

        public static void GetUniqueLetters(string input, List<char> letters)
        {
            foreach (char c in input)
            {
                if (Char.IsWhiteSpace(c))
                {
                    continue;
                }

                if (!letters.Contains(c))
                {
                    letters.Add(c);
                }
            }
        }
    }
}
