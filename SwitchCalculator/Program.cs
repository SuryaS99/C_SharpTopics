using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                Console.WriteLine("Enter the First Number");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Symbol to perform Operation(+,-,/,*,%)");
                var symbol = Console.ReadLine();

                Console.WriteLine("Enter the Second Number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                switch (symbol)
                {
                    case "+":
                        Console.WriteLine("You perform Addtion");
                        Console.WriteLine($"The Addition of {num1} and {num2} is: {num1 + num2}");
                        break;

                    case "-":
                        Console.WriteLine("You perform Subtraction");
                        Console.WriteLine($"The Subtraction of {num1} and {num2} is: {num1 - num2}");
                        break;

                    case "/":
                        Console.WriteLine("You perform Division");
                        Console.WriteLine($"The Division of {num1} and {num2} is: {num1 / num2}");
                        break;

                    case "%":
                        Console.WriteLine("You perform Modulus");
                        Console.WriteLine($"The Modulus of {num1} and {num2} is: {num1 % num2}");
                        break;

                    default:
                        Console.WriteLine("Please select valid symbol!!!");
                        break;

                }
                Console.ReadLine();
                Console.WriteLine("Press Y to continue or Press N to Stop");
                value = Console.ReadLine();
            }
            while (value == "Y" || value == "y");
        }
    }
}
