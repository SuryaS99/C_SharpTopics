using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implicit Conversion");
            byte b = 4; //8-bit
            int a = b;//32-bit
            long l = a;//64-bit
            Console.WriteLine(l);

            Console.WriteLine("Explicit Conversion");
            long g = 265;
            int j = (int)g;
            byte u = (byte)j;
            Console.WriteLine("Convert long to integer to integer " + u);

            Console.WriteLine("Conversion of non compaitable type");

            Console.WriteLine("By Parse Method:");
            string s = "123456";
            int no = int.Parse(s);
            Console.WriteLine("Convert String to integer " + no);

            Console.WriteLine("By Convert to Class:");
            string st = "1473896";
            int cNo = Convert.ToInt32(st);
            Console.WriteLine("Convert String to integer " + cNo);

            Console.ReadLine();
        }
    }
}
