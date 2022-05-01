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

            foreach (var letter in lettersDict)
            {
                Console.WriteLine(letter);
            }
            
        }
    }
}
