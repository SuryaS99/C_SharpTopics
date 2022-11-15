using System;

namespace MethodWithReturnType
{
    class Program
    {
        // method with argument and return type
        public int Greater(int num1, int num2)
        {

            int result;
            if (num1 > num2)
            {
                result = num1;

            }
            else
            {
                result = num2;
            }
            return result;
        }

        // method with no argument and no return type

        void NoArgument()
        {
            Console.WriteLine("method with no argument and no return type");
            Console.ReadLine();
        }

        //method with argument and no return type

        void Argument(int a, int b)
        {

            Console.WriteLine("method with argument and no return type");
            Console.WriteLine(a + b);
            Console.ReadLine();
        }

        //method with no agrument and return type        
        public int Returns()
        {
            int a = 20;
            int b = 68;
            int result = a + b;
            Console.WriteLine("method with no agrument and return type ");
            Console.ReadLine();
            return result;
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine(obj.Greater(10, 7));
            Console.ReadLine();
            obj.NoArgument();
            obj.Argument(20, 56);
            obj.Returns();

        }
    }
}
