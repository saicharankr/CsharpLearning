using System;

namespace CsharpLearning
{
    internal class Square
    {
        private float fLength;
        private float fWidth;

        public void AcceptDetails()
        {
            Console.WriteLine("Enter the length of side  \n");
            fLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Width of side  \n");
            fWidth = Convert.ToInt32(Console.ReadLine());
        }

        public float GetArea()
        {
            return fLength * fWidth;
        }

        public string CheckRectangeOrSquare()
        {
            if (fLength == fWidth)
            {
                return "Square";
            }
            else
            {
                return "Rectangle";
            }
        }

        public void Display()
        {
            Console.WriteLine("Area : " + GetArea());
            Console.WriteLine(CheckRectangeOrSquare());
        }
    }
}