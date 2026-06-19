using System;
using System.Collections.Generic;

class Account
{
    public string Name;
    public double Balance;
}

class Program
{
    static void Main()
    {
        List<Account> accounts = new List<Account>();

        while (true)
        {
            Console.WriteLine("\n1-Create 2-Deposit 3-Withdraw 4-Exit");
            string c = Console.ReadLine();

            if (c == "1")
            {
                Account a = new Account();

                Console.Write("Name: ");
                a.Name = Console.ReadLine();

                a.Balance = 0;
                accounts.Add(a);
            }
            else if (c == "2")
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                foreach (var a in accounts)
                    if (a.Name == name)
                    {
                        Console.Write("Amount: ");
                        a.Balance += Convert.ToDouble(Console.ReadLine());
                    }
            }
            else if (c == "3")
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                foreach (var a in accounts)
                    if (a.Name == name)
                    {
                        Console.Write("Amount: ");
                        double amt = Convert.ToDouble(Console.ReadLine());

                        if (amt <= a.Balance)
                            a.Balance -= amt;
                    }
            }
            else break;
        }
    }
}
