using System;

namespace ConditionalStatementIF
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20, b = 30, c = 10;

            if (a > b && a > c)
            {
                Console.WriteLine("A is greater than B and C");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("B is greater than C and A");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("C is greater than A and B");
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
            Console.ReadLine();
        }
    }
}
