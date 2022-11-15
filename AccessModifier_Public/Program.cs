using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier_Public
{
    class PublicModifier
    {
        public string model;
        public string color;
        public int price;

        public void Car()
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
            PublicModifier obj = new PublicModifier();
            obj.model = "Maruti";
            obj.color = "Red";
            obj.price = 230000;
            obj.Car();
        }
    }
}
