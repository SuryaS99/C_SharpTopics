using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> info = new List<string>();
            info.Add("Quality");
            info.Add("Purification");
            info.Add("Delta");
            info.Add("Bachgen");
            info.Add("Delight");

            for (int i = 0; i < info.Count; i++)
                Console.WriteLine(info[i]);
            //or
            Console.WriteLine("_________________________________");
            foreach (string item in info)
                Console.WriteLine(item);
            Console.ReadLine();
        }
    }
}
