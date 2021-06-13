using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetLength();
            rectangle.SetBreadth();
            Calculate(rectangle);
            Console.WriteLine("\n");
            Circle circle = new Circle();
            circle.SetRadius();
            Calculate(circle);
        }
        public static void Calculate(Shape1 S)
        {
            Console.WriteLine("Area : {0}", S.Area());
            Console.WriteLine("Circumference : {0}", S.Circumference());
        }
    }
}
