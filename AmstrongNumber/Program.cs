using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 153;
            int res = 0;
            int rem;
            int cube;
            int temp = num;
            while (num != 0)
            {
                rem = num % 10;
                cube = rem * rem * rem;
                res = res + cube;
                num = num / 10;

            }
            num = temp;
            if (res == num)
            {
                Console.WriteLine("Amstrong number");
            }
            else
            {
                Console.WriteLine("Not a Amstrong number");
            }

            Console.ReadLine();
        }
    }
}
