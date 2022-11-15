using System;

namespace Constructor
{
    class constOverloading
    {
        public int PersonAge;
        public string PersonName;
        public constOverloading(string Name, int age)
        {
            PersonName = Name;
            PersonAge = age;

        }
        public constOverloading(int age, string Name)
        {
            PersonName = Name;
            PersonAge = age;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            constOverloading obj = new constOverloading("Dipak", 23);
            Console.WriteLine("Name: " + obj.PersonName);
            Console.WriteLine("Age: " + obj.PersonAge);
            constOverloading obj1 = new constOverloading(25, "Annu");
            Console.WriteLine("Name: " + obj1.PersonName);
            Console.WriteLine("Age: " + obj1.PersonAge);
            Console.ReadLine();
        }
    }
}
