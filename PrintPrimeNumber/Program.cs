using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;


            for (int num = 1; num <= a; num++)
            {
                // Console.WriteLine(num);
                int count = 0;
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {

                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(num);
                }

            }
            Console.ReadLine();
        }
    }
}
