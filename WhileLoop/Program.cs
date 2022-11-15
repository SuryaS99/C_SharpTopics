using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            int i = 0;
            while (i < a)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadLine();

        }
    }
}
