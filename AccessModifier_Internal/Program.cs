using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier_Internal
{
    class InternalModifier
    {

        internal string model;
        internal string color;
        internal int price;

        internal void Car()
        {
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Price: " + price);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            InternalModifier obj = new InternalModifier();
            obj.model = "Farari";
            obj.color = "Red";
            obj.price = 2439000;
            obj.Car();
        }
    }
}
