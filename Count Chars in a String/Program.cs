using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] word = Console.ReadLine().Split();
            Dictionary<char, int> charAndHisOccurrences = new Dictionary<char, int>();
            for (int i = 0; i < word.Length; i++)
            {
                string tempWord = word[i];
                for (int j = 0; j < tempWord.Length; j++)
                {
                    if (!charAndHisOccurrences.ContainsKey(tempWord[j]))
                    {
                        charAndHisOccurrences.Add(tempWord[j], 0);
                    }
                    charAndHisOccurrences[tempWord[j]]++;
                }
            }
            foreach (var item in charAndHisOccurrences)
            {
                Console.Write($"\n{item.Key} -> {item.Value}");
            }
        }
    }
}
