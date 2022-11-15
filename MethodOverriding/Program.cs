using System;

namespace MethodOverriding
{
    class Animal
    {
        void Eat()
        {
            Console.WriteLine("Animal is sleeping");
        }
    }
    class Cat : Animal
    {
        void Eat()
        {
            Console.WriteLine("Cat is Sleeping");
        }
        static void Main(string[] args)
        {
            Cat obj = new Cat();
            obj.Eat();
            Console.ReadLine();
        }
    }
}
