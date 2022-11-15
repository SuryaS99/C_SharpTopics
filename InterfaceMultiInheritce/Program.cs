using System;

namespace InterfaceMultiInheritce
{
    interface IA
    {
        void Print();
    }

    interface IB
    {
        void Print();
    }

    interface IC
    {
        void PrintC();
    }

    class A : IA
    {
        public void Print()
        {
            Console.WriteLine("A Implement");
        }
    }
    class B : IB
    {
        public void Print()
        {
            Console.WriteLine("B Implement");
        }
    }

    class C : IC
    {
        public void PrintC()
        {
            Console.WriteLine("C Implement");
        }

    }

    class D : IB, IC
    {
        public void Print()
        {
            Console.WriteLine("Override B");
        }
        public void PrintC()
        {
            Console.WriteLine("Override C");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            D obj = new D();
            obj.Print();
            obj.PrintC();
        }
    }
}
