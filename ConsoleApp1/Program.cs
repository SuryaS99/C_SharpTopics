using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapWithoutThird
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 90;
            int b = 50, c = 30, d = 10;
            //d = a + b + c + d; //30+20+60+70=180
            //c = d-(a + b + c); //180-30+20+60=70
            //b = d-(a + b + c); //180-30+20+70=60
            //a = d - (a + b + c);//180-30+60+70=20
            //d = d - (a + b + c); //180-20+60+70=30

            //or

            a = a + b + c + d;
            b = a - b - c - d;
            c = a - b - c - d;
            d = a - b - c - d;
            a = a - b - c - d;

            Console.WriteLine("Swap of a is: " + a);
            Console.WriteLine("Swap of b is: " + b);
            Console.WriteLine("Swap of c is: " + c);
            Console.WriteLine("Swap of d is: " + d);
            Console.ReadLine();

        }
    }
}
