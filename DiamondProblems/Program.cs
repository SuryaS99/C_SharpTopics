using System;

namespace DiamondProblems
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Implementation");
        }
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B Implementation");
        }
    }

    class C : A
    {
        public override void Print()
        {
            Console.WriteLine("C Implementation");
        }
    }
    // to sovle the diamond problem bug we have to use interface to perform multiple inheritance.
    class D : B//,C
    {
        //public virtual void Print()
        //{
        //    Console.WriteLine("A Implementation");
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            D info = new D();
            info.Print();
        }
    }
}
