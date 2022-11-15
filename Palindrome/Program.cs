using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 128;
            int rem;
            int result = 0;
            int temp = 121;
            while (num != 0)
            {

                rem = num % 10;
                num = num / 10;
                result = result * 10 + rem;

            }
            num = temp;
            if (result == num)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }

            Console.ReadLine();


        }
    }
}
