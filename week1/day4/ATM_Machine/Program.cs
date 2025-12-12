using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the ATM Machine!\n");

        // Create a list of accounts
        List<Account> accounts = new List<Account>()
        {
            new Account("12345", 1111, 1000),
            new Account("67890", 2222, 1500),
            new Account("55555", 3333, 500)
        };

        ATM atm = new ATM();
        Account user = null;

        // Authentication loop
        while (user == null)
        {
            user = atm.Authenticate(accounts);
        }

        string choice = "";
        while (choice != "5")
        {
            atm.ShowMenu();
            choice = Console.ReadLine();
            Console.WriteLine();
            atm.PerformAction(user, choice);
            Console.WriteLine();
        }

        // Exit summary
        Console.WriteLine("\nThank you for using our ATM.");
        user.ShowTransactions();
    }
}
