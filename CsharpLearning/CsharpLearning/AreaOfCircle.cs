using System;

namespace CsharpLearning
{
    internal class AreaOfCircle
    {
        private const double pi = 3.14;  // is a constant or floating literal

        private double r; // variable  declaration

        public void GetRadius()
        {
            Console.WriteLine("Enter the Radius of Circle");
            r = Convert.ToDouble(Console.ReadLine());
        }

        public double GetArea()
        {
            return pi * r * r;
        }

        public void Display()
        {
            Console.WriteLine("Area of Circle is \n" + GetArea());// Here /n is the string literal
        }
    }
}