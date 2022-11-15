using System;
using System.Diagnostics;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch(); //created new stopwatch object
            stopwatch.Start(); //start the watch
                               //using for loop print the input no of times
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " hello" + " ");
            }
            //stop the watch
            stopwatch.Stop();
            // to display actual time here we used the time elapsed
            Console.WriteLine("Time Elapsed : {0}", stopwatch.Elapsed);
            Console.ReadLine();
        }
    }
}
