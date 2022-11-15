using System;

namespace ClassAndObjects
{
    class Program
    {
        int num1;
        int num2;
        int result;
        void Add()
        {
            result = num1 + num2;
            Console.WriteLine("The addition of a number is " + result);

        }
        void Sub()
        {
            result = num1 - num2;
            Console.WriteLine("The subtraction of a number is " + result);

        }
        void Multi()
        {
            result = num1 * num2;
            Console.WriteLine("The multiplication of two number is " + result);


        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.num1 = 50;
            obj.num2 = 5;
            obj.Add();
            obj.Sub();
            obj.Multi();
        }
    }
}
