using System;
using System.Diagnostics;
using System.Threading;

namespace StopwatchWithThreading
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //time to display after a seconds
            Thread.Sleep(20000);
            stopwatch.Stop();

            //geting the elapsed time as a timespan value
            TimeSpan ts = stopwatch.Elapsed;

            // format to display timspan value
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            //print the value;
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}
