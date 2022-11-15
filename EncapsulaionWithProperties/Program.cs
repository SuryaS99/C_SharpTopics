using System;

namespace EncapsulaionWithProperties
{
    class Account
    {
        int accBalance = 1000;

        // using c# property access private variable
        public int Balance
        {
            set
            {
                if (value < 0)
                    Console.WriteLine("Account balance can not be negative!!!");
                else
                    accBalance = value;
            }
            get
            {
                return accBalance;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account info = new Account();
            info.Balance = 20000;
            Console.WriteLine("Your Balance amount is: " + info.Balance);
            Console.ReadLine();

        }
    }
}
