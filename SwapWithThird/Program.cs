using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapWithThird
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 20;
            int c = 40;
            int d = 50;
            int e;
            e = a;
            a = b;
            b = c;
            c = d;
            d = e;
            Console.WriteLine("Swap of a is: " + a);
            Console.WriteLine("Swap of b is: " + b);
            Console.WriteLine("Swap of c is: " + c);
            Console.WriteLine("Swap of d is: " + d);
            Console.ReadLine();
        }
    }
}
