using System;
using System.Collections.Generic;

namespace Chapter3Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string test = System.IO.File.ReadAllText(@"/Users/karakilkenny/codecamp2020/c-sharp/csharp-studios/Chapter3Studio/Chapter3Studio/TextFile.txt");
            CountingCharacters(test);

            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            CountingCharacters(input);
        }


        static void CountingCharacters(string paragraph)
        {
            paragraph = paragraph.ToLower();
            Dictionary<char, int> newDictionary = new Dictionary<char, int>();
            char[] charactersInString = paragraph.ToCharArray();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < charactersInString.Length; i++)
            {
                if (!newDictionary.ContainsKey(charactersInString[i]) && alphabet.Contains(charactersInString[i]))
                {
                    int n = 0;
                    foreach (char item in charactersInString)
                    {
                        if (item == charactersInString[i])
                        {
                            n++;
                        }
                    }
                    newDictionary.Add(charactersInString[i], n);
                }
            }
            foreach (KeyValuePair<char, int> item in newDictionary)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}