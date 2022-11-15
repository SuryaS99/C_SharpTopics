using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier_Private
{
    class Program
    {

        private string model;
        private string color;
        private int price;

        private void Car()
        {
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Price: " + price);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.model = "Farari";
            obj.color = "Blue";
            obj.price = 300000;
            obj.Car();
        }
    }
}
