using System;
using System.Collections.Generic;

public class BankSystem
{
    private Dictionary<string, decimal> accounts = new Dictionary<string, decimal>();
    
    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\nBank System Menu:");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Check Balance");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            
            string? choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    CreateAccount();
                    break;
                case "2":
                    Deposit();
                    break;
                case "3":
                    Withdraw();
                    break;
                case "4":
                    CheckBalance();
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }
    
    public void CreateAccount()
    {
        Console.Write("Enter account number: ");
        string? accountNumber = Console.ReadLine();
        
        if (!accounts.ContainsKey(accountNumber!))
        {
            accounts[accountNumber!] = 0;
            Console.WriteLine("Account created successfully.");
        }
        else
        {
            Console.WriteLine("Account already exists.");
        }
    }
    
    public void Deposit()
    {
        Console.Write("Enter account number: ");
        string? accountNumber = Console.ReadLine();
        
        Console.Write("Enter deposit amount: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
        {
            if (accounts.ContainsKey(accountNumber!))
            {
                accounts[accountNumber!] += amount;
                Console.WriteLine($"Deposited {amount} successfully. New balance: {accounts[accountNumber!]}");
            }
            else
            {
                Console.WriteLine("Account does not exist.");
            }
        }
        else
        {
            Console.WriteLine("Invalid amount.");
        }
    }
    
    public void Withdraw()
    {
        Console.Write("Enter account number: ");
        string? accountNumber = Console.ReadLine();
        
        Console.Write("Enter withdrawal amount: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
        {
            if (accounts.ContainsKey(accountNumber!))
            {
                if (accounts[accountNumber!] >= amount)
                {
                    accounts[accountNumber!] -= amount;
                    Console.WriteLine($"Withdrawn {amount} successfully. New balance: {accounts[accountNumber!]}");
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }
            else
            {
                Console.WriteLine("Account does not exist.");
            }
        }
        else
        {
            Console.WriteLine("Invalid amount.");
        }
    }
    
    public void CheckBalance()
    {
        Console.Write("Enter account number: ");
        string? accountNumber = Console.ReadLine();
        
        if (accounts.ContainsKey(accountNumber!))
        {
            Console.WriteLine($"Balance: {accounts[accountNumber!]}");
        }
        else
        {
            Console.WriteLine("Account does not exist.");
        }
    }
}
