using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurssion
{
    class Program
    {
        int num = 1;
        void Counting()
        {
            if (num == 20)
            {
                return;
            }
            Console.WriteLine(num);
            num++;
            Counting();

        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Counting();
            Console.ReadLine();
        }
    }
}
