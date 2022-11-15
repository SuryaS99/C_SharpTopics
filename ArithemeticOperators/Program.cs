using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithemeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 40;
            int secondNumber = 20;
            var result = firstNumber + secondNumber;
            Console.WriteLine(result);
            Console.WriteLine(firstNumber - secondNumber);
            Console.WriteLine(firstNumber * secondNumber);
            Console.WriteLine(firstNumber / secondNumber);
            Console.WriteLine(firstNumber % secondNumber);
            Console.ReadLine();
        }
    }
}
