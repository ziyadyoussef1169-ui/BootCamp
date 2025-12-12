//Exercise 1: Birthday Look-up

using System;
using System.Collections.Generic;

class Exercise1
{
    static void Main()
    {
        var birthdays = new Dictionary<string, string>
        {
            {"Alice", "1990/05/12"},
            {"Bob", "1985/11/23"},
            {"Charlie", "1992/07/08"},
            {"Diana", "1988/02/20"},
            {"Eve", "1995/09/30"}
        };

        Console.WriteLine("Welcome! You can look up birthdays.");
        Console.Write("Enter a name: ");
        string name = Console.ReadLine() ?? "";

        if (birthdays.ContainsKey(name))
            Console.WriteLine($"{name}'s birthday is {birthdays[name]}.");
        else
            Console.WriteLine($"Sorry, we don’t have the birthday information for {name}.");
    }
}

//Exercise 2: Birthdays Advanced

class Exercise2
{
    static void Main()
    {
        var birthdays = new Dictionary<string, string>
        {
            {"Alice", "1990/05/12"},
            {"Bob", "1985/11/23"},
            {"Charlie", "1992/07/08"},
            {"Diana", "1988/02/20"},
            {"Eve", "1995/09/30"}
        };

        Console.WriteLine("We have birthdays for:");
        foreach (var name in birthdays.Keys)
            Console.WriteLine(name);

        Console.Write("Enter a name: ");
        string nameInput = Console.ReadLine() ?? "";

        if (birthdays.ContainsKey(nameInput))
            Console.WriteLine($"{nameInput}'s birthday is {birthdays[nameInput]}.");
        else
            Console.WriteLine($"Sorry, we don’t have the birthday information for {nameInput}.");
    }
}

//Exercise 3: Sum Sequence


class Exercise3
{
    static int SumSequence(int x)
    {
        int x1 = x;
        int x2 = int.Parse($"{x}{x}");
        int x3 = int.Parse($"{x}{x}{x}");
        int x4 = int.Parse($"{x}{x}{x}{x}");
        return x1 + x2 + x3 + x4;
    }

    static void Main()
    {
        Console.Write("Enter an integer X: ");
        int x = int.Parse(Console.ReadLine() ?? "0");

        int result = SumSequence(x);
        Console.WriteLine($"X + XX + XXX + XXXX = {result}");
    }
}

//Exercise 4: Double Dice Simulation


class Exercise4
{
    static int ThrowDice()
    {
        Random rnd = new Random();
        return rnd.Next(1, 7); // 1 to 6
    }

    static int ThrowUntilDoubles()
    {
        int rolls = 0;
        int die1, die2;
        do
        {
            die1 = ThrowDice();
            die2 = ThrowDice();
            rolls++;
        } while (die1 != die2);

        return rolls;
    }

    static void MainSimulation()
    {
        List<int> results = new List<int>();
        for (int i = 0; i < 100; i++)
            results.Add(ThrowUntilDoubles());

        int totalThrows = results.Sum();
        double avgThrows = results.Average();

        Console.WriteLine($"Total number of throws: {totalThrows}");
        Console.WriteLine($"Average throws to reach doubles: {avgThrows:F2}");
    }

    static void Main()
    {
        MainSimulation();
    }
}
