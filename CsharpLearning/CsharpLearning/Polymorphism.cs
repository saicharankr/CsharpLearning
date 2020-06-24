using System;

namespace CsharpLearning
{
    //This explains static polymorphism by function overloading
    public class Polymorphism
    {
        public void Demo(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }

        public void Demo(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }

        public void Demo(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
    }
}