using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Task<int> result1 = Long();
            Task<int> result2 = Short();

            var value = await result1;
            var value1 = await result2;

            Console.WriteLine("Result{0}", value);
            Console.WriteLine("Result{0}", value1);
            //Console.ReadKey();
        }

        public static async Task<int> Long()
        {
            Console.WriteLine("Long Process Start");
            await Task.Delay(5000);
            Console.WriteLine("Long process End");
            await Task.Delay(3000);
            return 10;
        }

        static async Task<int> Short()
        {


            Console.WriteLine("Short Process Start");
            await Task.Delay(3000);
            Console.WriteLine("Short process End");
            await Task.Delay(5000);
            return 20;
        }
    }
}
