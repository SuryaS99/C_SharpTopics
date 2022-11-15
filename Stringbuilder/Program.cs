using System;
using System.Text;

namespace Stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder st = new StringBuilder("Hywl bachgen and creso Megan");
            for (int i = 0; i < st.Length; i++)
            {
                Console.WriteLine(st[i]);
            }
        }
    }

}
