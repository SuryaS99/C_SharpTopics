using System;
using System.Collections.Generic;

namespace InumeratorAndInumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> oyear = new List<int>();
            oyear.Add(1997);
            oyear.Add(1998);
            oyear.Add(1999);
            oyear.Add(2000);
            oyear.Add(2001);
            oyear.Add(2002);
            oyear.Add(2003);
            oyear.Add(2004);

            Console.WriteLine("IEnumerable method");
            IEnumerable<int> ienum = (IEnumerable<int>)oyear;
            Itrate98to2001(ienum);


            static void Itrate98to2001(IEnumerable<int> year)
            {
                //itrate value from 1998 to 2001


                foreach (var i in year)
                {
                    if (i > 2000)
                    {
                        Itrate2001toabove(year);
                    }

                }
            }
            static void Itrate2001toabove(IEnumerable<int> year)
            {
                //itrate value from 2001 to 2004
                foreach (var i in year)
                {
                    Console.WriteLine(i);

                }
            }


            Console.WriteLine("IEnumerator method");

            //IEnumerator<int> ienumerat = oyear.GetEnumerator();
            //Itrate98to2001(ienumerat);

            //static void Itrate98to2001(IEnumerator<int> year)
            //{
            //    //itrate value from 1998 to 2001


            //    while (year.MoveNext())
            //    {
            //        Console.WriteLine(year.Current.ToString());
            //        if (Convert.ToInt16(year.Current) > 2000)
            //        {
            //            Itrate2001toabove(year);
            //        }
            //    }
            //}
            //static void Itrate2001toabove(IEnumerator<int> year)
            //{
            //    //itrate value from 2001 to 2004
            //    while (year.MoveNext())
            //    {
            //        Console.WriteLine(year.Current.ToString());
            //    }
            //}
        }
    }
}

