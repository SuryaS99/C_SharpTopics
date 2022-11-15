using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RtAngle_StarPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //arrow in square
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    if (i == 10 || i == 0 || j == 0 || j == 10)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();


            // upside down  rt angle
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 10; j > i; j--)
            //    {
            //           Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            //upside down hollow rt angle
            //for (int i = 1; i <=10; i++)
            //{
            //    for (int j = 10; j >i ; j--)
            //    {
            //        if(i==1 ||j==1+i ||j==10 || i == 10 ||j==i)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            //diagonal square

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <=10; j++)
            //    {
            //        if (i == 10 || i == 1 || i ==10- j+1 || j == 1 || j == i ||j==10 ||j==10)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();



            //triangle with inner triangle

            //for (int i = 1; i <=10; i++)
            //{
            //    for (int j = 1; j <i; j++)
            //    {
            //        if(i==10||i ==1 ||i==j ||j==1 || j == i ||i==j+1 ||i==j+5 )
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            //hallow rigth angle triangle
            //for (int i = 1; i <=10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i==1 || i == 10 || j == 1 || j == i)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();




            //hollow square
            //for (int i = 1; i <=10; i++)
            //{
            //    for (int j = 1; j <=10; j++)
            //    {
            //        if(i==1 ||j==1 || i == 10 || j==10)
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();




            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
        }
    }
}
