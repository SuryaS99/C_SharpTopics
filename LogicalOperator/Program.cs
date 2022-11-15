using System;

namespace LogicalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20, b = 10, c = 20;
            Console.WriteLine(a == b && b == c);
            Console.WriteLine(a == b || b == c);
            Console.WriteLine(!(a == b || b == c));//not operator
        }
    }
}
