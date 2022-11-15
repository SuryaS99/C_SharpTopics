using System;

namespace Fibonacii
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("Fibonacii Series start");
            for (int i = 0; i < 10; i++)
            {

                int fibo = a + b;
                Console.WriteLine(fibo);
                a = b;
                b = fibo;
            }
            Console.ReadLine();
        }
    }
}
