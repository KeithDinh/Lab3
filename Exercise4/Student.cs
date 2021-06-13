using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class");
        }
        public void showAge()
        {
            Console.WriteLine($"My age is: {Age}");
        }
    }
}
