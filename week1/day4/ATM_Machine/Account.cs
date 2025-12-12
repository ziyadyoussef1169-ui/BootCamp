using System;
using System.Collections.Generic;

public class Account
{
    public string AccountNumber { get; set; }
    public int PIN { get; set; }
    public double Balance { get; set; }
    public List<string> Transactions { get; set; }

    public Account(string accNum, int pin, double balance)
    {
        AccountNumber = accNum;
        PIN = pin;
        Balance = balance;
        Transactions = new List<string>();
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Your balance is: ${Balance}");
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive!");
            return;
        }

        Balance += amount;
        Transactions.Add($"Deposited: ${amount}");
        Console.WriteLine($"Deposit successful! New balance: ${Balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be positive!");
            return;
        }

        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds!");
            return;
        }

        Balance -= amount;
        Transactions.Add($"Withdrew: ${amount}");
        Console.WriteLine($"Withdrawal successful! New balance: ${Balance}");
    }

    public void ShowTransactions()
    {
        Console.WriteLine("\nTransaction History:");

        if (Transactions.Count == 0)
        {
            Console.WriteLine("No transactions yet.");
            return;
        }

        foreach (var t in Transactions)
        {
            Console.WriteLine(t);
        }
    }
}
