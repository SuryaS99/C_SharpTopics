using System;
using System.Text;

namespace Stringbuilder2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder st = new StringBuilder("Creso, Owen!!!! ", 30);
            st.Append("Owen dw i");
            st.AppendLine("merch a dwy");
            st.AppendLine("Prynhawn da Owen");

            Console.WriteLine(st);
        }
    }
}
