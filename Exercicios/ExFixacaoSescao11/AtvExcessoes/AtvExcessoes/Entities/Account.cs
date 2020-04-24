using System;
using AtvExcessoes.Entities.Exceptions;

namespace AtvExcessoes.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }


        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Withdraw(double value)
        {
            if (value <= WithdrawLimit)
            {
                if (value <= Balance)
                    Balance -= value;
                else
                    throw new DomainException("Not enough balance");
            }
            else
                throw new DomainException("The amount exceeds the withdraw limit");
        }

        public void Deposit(double value)
        {
            Balance += value;
        }


    }
}
