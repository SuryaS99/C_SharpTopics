using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123456;
            int rev = 0;
            int rem;
            while (a != 0)
            {
                rem = a % 10; //remainder value
                rev = rev * 10 + rem;  //result value
                a = a / 10;              // question value  
            }
            Console.WriteLine(rev);
            Console.ReadLine();

        }
    }
}
