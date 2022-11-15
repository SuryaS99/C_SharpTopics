using System;
using System.Collections.Generic;

namespace List_Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallests = GetSmallests(numbers, 3);

            //foreach (var number in smallests)
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            if (list == null)
                throw new ArgumentOutOfRangeException("list");


            //costum error output
            //if the range of the list count is greater or greater than or = 0 then the exception error will occur
            if (count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("count", "Count should be between 1 and the number of elemens in the list.");

            var buffer = new List<int>(list);
            var smallests = new List<int>();
            while (smallests.Count < count)
            {
                //var min = GetSmallest(list);
                var min = GetSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
                //list.Remove(min);
            }
            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            //assume first element is smallest
            var min = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                // this was a bug (list[1]>min) it will print max value
                if (list[i] < min)
                {
                    min = list[i];
                }
            }
            return min;

        }
    }
}
