using System;

namespace Constructor_Overloading
{
    class Program
    {
        // constructor 1
        public Program()
        {
            Console.WriteLine("This is a first constructor");
        }

        public Program(int a, int b)
        {
            Console.WriteLine("This is a second constructor!! {0}", (a + b));
        }


        public Program(int a, int b, int c)
        {
            Console.WriteLine("This is a third constructor!! {0}", (a + b + c));
        }

        public Program(string a, string b, string c)
        {
            Console.WriteLine("This is a Fourth constructor!! {0}", (a + b + c));
        }
        static void Main(string[] args)
        {
            //Constructor can be called when we create object of a class.

            Program p = new Program("A", "B", "C");
            Console.ReadLine();

        }
    }
}
