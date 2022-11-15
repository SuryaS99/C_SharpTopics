using System;
using System.Threading.Tasks;

namespace AsyncAwaitParameter
{
    class Program
    {
        static async Task<int> Add(int a, int b)
        {
            int c = a + b;
            await Task.Delay(5000);
            Console.WriteLine("The Addition task run ");
            return c;
        }

        static async Task<int> Sub(int a, int b)
        {
            int c = a - b;
            await Task.Delay(1000);
            Console.WriteLine("The Subtraction task run " + c);
            return c;
        }
        static async Task Main(string[] args)
        {
            Task<int> add = Add(30, 80);
            Task<int> sub = Sub(39, 27);
            var addValue = await add;
            var subValue = await sub;
            //Console.WriteLine("The Addition of two no is " + addValue);
            //Console.WriteLine("The Subtraction of two no is " +subValue);
        }


    }
}
