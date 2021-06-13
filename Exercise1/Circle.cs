using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Circle : Shape1
    {
        private const float PI = 3.14f;
        public void SetRadius()
        {
            Console.Write("Enter Radius : "); this.R = (float)Convert.ToDecimal(Console.ReadLine());
        }
        public override float Area()
        {
            return (float)(PI * Math.Pow(R,2));
        }
        public override float Circumference()
        {
            return 2 * PI * R;
        }
    }
}
