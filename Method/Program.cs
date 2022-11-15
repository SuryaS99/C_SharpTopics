using System;

namespace Method
{
    public class ADD
    {
        //static int is a method return type
        public static int add(int d, int e)
        {

            return d + e;
        }
        public static int add(int d, int e, int f)
        {

            return d + e + f;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ADD.add(20, 40)); //ADD is a identifer
            Console.WriteLine(ADD.add(20, 40, 76));
        }
    }
}
