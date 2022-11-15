using System;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < a);
        }
    }
}
