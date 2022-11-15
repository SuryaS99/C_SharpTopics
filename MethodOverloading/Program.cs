using System;

namespace MethodOverloading
{
    class Program
    {
        void result(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        void result(float a, float b)
        {
            Console.WriteLine(a + b);
        }
        static void Main(string[] args)
        {

            Program obj = new Program();
            obj.result(40.5f, 35.7f);
            Console.ReadLine();

        }
    }
}
