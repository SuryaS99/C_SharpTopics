using System;

namespace Structure
{
    struct Coordinate
    {
        public int x;
        public int y;
        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
        public static Coordinate GetOrigin()
        {
            return new Coordinate();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate point = Coordinate.GetOrigin();
            Console.WriteLine(point.x);

        }
    }
}
