using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Rectangle : Shape1
    {
        public void SetLength()
        {
            Console.Write("Enter Length : "); this.L = (float)Convert.ToDecimal(Console.ReadLine());
        }
        public void SetBreadth()
        {
            Console.Write("Enter Breadth : "); this.B = (float)Convert.ToDecimal(Console.ReadLine());
        }
        public override float Area()
        {
            return L * B;
        }
        public override float Circumference()
        {
            return (L + B) * 2;
        }
    }
}
