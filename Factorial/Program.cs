using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= a; i++)
            {

                fact = fact * i;
                Console.WriteLine(fact);
            }
            Console.ReadLine();
        }
    }
}
