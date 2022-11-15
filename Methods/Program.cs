using System;

namespace Methods
{
    class Program
    {
        int num1 = 30;
        int num2 = 90;
        int result;

        void Add()
        {
            result = num1 + num2;
            DisplayResult();
        }
        void Subtract()
        {
            result = num1 - num2;
            DisplayResult();
        }
        void Multi()
        {
            result = num1 * num2;
            DisplayResult();
        }
        void Div()
        {
            result = num1 / num2;
            DisplayResult();
        }
        void Module()
        {
            result = num1 % num2;
            DisplayResult();
        }
        void DisplayResult()
        {

            Console.WriteLine(result);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Add();
            obj.Subtract();
            obj.Multi();
            obj.Div();
            obj.Module();
        }
    }
}
