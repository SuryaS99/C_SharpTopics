using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {

                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine($"{num} is a Prime number");
            }
            else
            {
                Console.WriteLine($"{num} is not a Prime number");
            }
            Console.ReadLine();

        }
    }
}
