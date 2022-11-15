using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecussionFact
{
    class Program
    {
        int num = 5;
        int result = 1;
        public int Fact()
        {
            if (num == 0)
            {
                return 1;
            }
            result = result * num;
            num--;
            Fact();
            return result;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int a = obj.Fact();
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
