using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third number");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("A is bigger than B & C");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("B is bigger than A & C");
            }
            else if (c > b && c > a)
            {
                Console.WriteLine("C is bigger than B & A");
            }
            else
            {
                Console.WriteLine("Condition can not match");
            }
            Console.ReadLine();
        }
    }
}
