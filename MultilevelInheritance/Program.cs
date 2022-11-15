using System;

namespace MultilevelInheritance
{
    class Animal
    {
        protected void Play()
        {
            Console.WriteLine("Animal is Playing");
        }
    }
    class Dog : Animal
    {
        protected void Sleep()
        {
            Console.WriteLine("Animal is sleepping");
        }
    }
    class Cat : Dog
    {
        void drink()
        {
            Console.WriteLine("Cat is drinking milk");
        }

        static void Main(string[] args)
        {
            Cat obj = new Cat();
            obj.Play();
            obj.Sleep();
            obj.drink();
            Console.ReadLine();
        }
    }
}
