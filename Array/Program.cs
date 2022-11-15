using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] info = new string[5] { "Hello", "Delight", "Quality", "Purification", "Mohak" };

            for (int i = 0; i < info.Length; i++)
                Console.WriteLine(info[i]);
            //or
            foreach (string item in info)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
