using System;

namespace Hierarchical_Inheritance
{
    class Animal
    {
        protected void Domestic()
        {
            Console.WriteLine("Domestic Animal");
        }
    }
    class Dog : Animal
    {
        protected void Wild()
        {
            Console.WriteLine("Dog can be wild");
        }
    }
    class Cat : Animal
    {
        void Bread()
        {
            Console.WriteLine("Cat can be of different bread");
        }
        static void Main(string[] args)
        {
            Cat obj = new Cat();
            obj.Domestic();
            obj.Bread();
            Console.ReadLine();
        }
    }
}
