using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string input = Console.ReadLine();

        Dictionary<char, List<int>> letterPositions = new Dictionary<char, List<int>>();

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (!letterPositions.ContainsKey(c))
            {
                letterPositions[c] = new List<int>();
            }
            letterPositions[c].Add(i);
        }

        Console.WriteLine("Result:");
        foreach (var kvp in letterPositions)
        {
            Console.WriteLine($"{kvp.Key}: [{string.Join(", ", kvp.Value)}]");
        }
    }
}
