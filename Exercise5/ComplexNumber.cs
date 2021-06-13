using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    class ComplexNumber
    {
        private int a = 0;
        private int b = 0;
        public ComplexNumber()
        {}
        public ComplexNumber(int real, int imagine)
        {
            this.a = real;
            this.b = imagine;
        }
        public void SetImaginary(int imagine) { this.b = imagine; }
        public void SetReal(int real) { this.a = real; }
        public string ToString()
        {
            return $"({a}, {b})";
        }
        public double GetMagnitude()
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
        public void Add(ComplexNumber num)
        {
            this.a += num.a;
            this.b += num.b;
        }
    }
}
