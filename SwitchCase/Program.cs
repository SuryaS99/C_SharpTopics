using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            switch (a)
            {
                case 1:
                    if (a == 1)
                    {
                        Console.WriteLine("You have selected one, So you will perform addition of two number");

                        Console.WriteLine("Enter the first number");
                        int b = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the second number");
                        int c = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"The Addition of {b} and {c} is {b + c}");
                    }
                    else
                    {
                        Console.WriteLine("Select the new number");
                    }
                    break;
                default:
                    Console.WriteLine("Please select the valid number");
                    break;

            }

            Console.ReadLine();
        }
    }
}
