using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables");

            //using camel case for identifier.
            byte smallNumber = 1;
            int largeNumber = 100;
            float pointValue = 2.3f;
            double largePointValue = 45.58;
            decimal valueOfPi = 34.23m;
            char singleLetter = 'a'; // char value assign in single quote and string in double quote.
            bool IsItTrue = true;

            Console.WriteLine(smallNumber);
            Console.WriteLine(largeNumber);
            Console.WriteLine(pointValue);
            Console.WriteLine(largePointValue);
            Console.WriteLine(valueOfPi);
            Console.WriteLine(singleLetter);
            Console.WriteLine(IsItTrue);
            Console.ReadLine();
        }
    }
}
