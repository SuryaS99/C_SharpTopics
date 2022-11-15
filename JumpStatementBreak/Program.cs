using System;

namespace JumpStatementBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                    break;

            }
            Console.ReadLine();
        }
    }
}
