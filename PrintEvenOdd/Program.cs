using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintEvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;


            Console.WriteLine("Print Even Number");
            for (int i = 1; i < a; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }

            //or

            for (int i = 1; i < a; i++)
            {
                if (i % 2 != 0)//if(i%2==1)
                {
                    continue;
                }
                Console.WriteLine(i);

            }

            Console.ReadLine();
        }
    }
}
