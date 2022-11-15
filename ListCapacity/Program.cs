using System;
using System.Collections.Generic;

namespace ListCapacity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The List in C# (basic Program using property Capacity)\n");

            List<int> a = new List<int>();
            a.Add(24);
            a.Add(35);
            a.Add(49);
            Console.WriteLine("\n The Capacity of List is: " + a.Capacity);
            Console.WriteLine("\n The Count of List is: " + a.Count);
        }
    }
}
