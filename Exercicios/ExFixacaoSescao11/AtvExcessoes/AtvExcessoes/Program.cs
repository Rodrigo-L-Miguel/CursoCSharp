using System;
using AtvExcessoes.Entities;
using AtvExcessoes.Entities.Exceptions;

namespace AtvExcessoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter acccount data");
                Console.Write("Number:");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder:");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance:");
                double initialBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw Limit:");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, initialBalance, withdrawLimit);

                Console.Write("Enter the amount to withdraw:");
                account.Withdraw(double.Parse(Console.ReadLine()));

                Console.WriteLine("New balance:" + account.Balance);
            }
            catch(DomainException e)
            {
                Console.WriteLine("Withdraw error:"+ e.Message);
            }
        }
    }
}
