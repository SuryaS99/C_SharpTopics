using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new List<string>
            {"Dog", "Cat", "Fish", "Elephant", "Zebra", "Deer", "Lepoard", "Giraffe"};

            var stopwatch = Stopwatch.StartNew();

            foreach (string ani in animal)
            {
                Console.WriteLine($"Animal name {ani}, Thread Id={Thread.CurrentThread.ManagedThreadId}");
            }
            Console.WriteLine($"ForLoop, execution time = {stopwatch.Elapsed.TotalSeconds} seconds");

            var stopwatchp = Stopwatch.StartNew();
            Parallel.ForEach(animal, _animal =>
            {
                Console.WriteLine($"Animal name {_animal}, Thread Id={Thread.CurrentThread.ManagedThreadId}");
            }
            );
            Console.WriteLine($"Parallel ForLoop, execution time = {stopwatch.Elapsed.TotalSeconds} seconds");
            Console.ReadLine();

        }
    }
}
