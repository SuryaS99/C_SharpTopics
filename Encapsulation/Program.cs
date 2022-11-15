using System;

namespace Encapsulation
{
    class Account
    {
        int accBalance = 2000;

        public void SetBalance(int amount)
        {
            if (amount < 0)
                Console.WriteLine("Your account balance cannot be negative");
            else
                accBalance = amount;
        }
        public void GetBalance()
        {
            Console.WriteLine("Your Balance amount is : " + accBalance);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account info = new Account();
            info.SetBalance(9000);
            info.GetBalance();
            Console.ReadLine();
        }
    }
}
