using System;
using System.Collections.Generic;

public class ATM
{
    public Account Authenticate(List<Account> accounts)
    {
        Console.Write("Please enter your account number: ");
        string accNum = Console.ReadLine();

        Console.Write("Enter your PIN: ");
        int pin = int.Parse(Console.ReadLine());

        foreach (var acc in accounts)
        {
            if (acc.AccountNumber == accNum && acc.PIN == pin)
            {
                Console.WriteLine("Authentication successful!\n");
                return acc;
            }
        }

        Console.WriteLine("Invalid account number or PIN!");
        return null;
    }

    public void ShowMenu()
    {
        Console.WriteLine("ATM Menu:");
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit Money");
        Console.WriteLine("3. Withdraw Money");
        Console.WriteLine("4. Show Transactions");
        Console.WriteLine("5. Exit");
        Console.Write("Select an option: ");
    }

    public void PerformAction(Account account, string choice)
    {
        switch (choice)
        {
            case "1":
                account.CheckBalance();
                break;

            case "2":
                Console.Write("Enter deposit amount: ");
                double dep = double.Parse(Console.ReadLine());
                account.Deposit(dep);
                break;

            case "3":
                Console.Write("Enter withdrawal amount: ");
                double w = double.Parse(Console.ReadLine());
                account.Withdraw(w);
                break;

            case "4":
                account.ShowTransactions();
                break;

            case "5":
                Console.WriteLine("Exiting...");
                break;

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}
