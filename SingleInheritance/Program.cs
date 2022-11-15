using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance
{
    class Animal
    {
        protected void Bark()
        {
            Console.WriteLine("People seeing Dog Barking in the garden ");
        }
    }
    class Dog : Animal
    {
        void Play()
        {
            Console.WriteLine("Also Dog  is playing in Garden");
        }
        static void Main(string[] args)
        {
            Dog obj = new Dog();
            obj.Bark();
            obj.Play();
            Console.ReadLine();
        }
    }
}
