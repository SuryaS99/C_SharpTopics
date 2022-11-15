using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Add
    {
        public Add()
        {
            Console.WriteLine("Enter First Number");
            int firstNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int secondNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The addition of {firstNo} and {secondNo} is {firstNo + secondNo}");

        }
    }
    class Sub
    {
        public Sub()
        {
            Console.WriteLine("Enter the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"The subtraction of {a} and {b} is {a - b}");

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Add Addition = new Add();
            Sub Subtract = new Sub();

        }
    }
}
