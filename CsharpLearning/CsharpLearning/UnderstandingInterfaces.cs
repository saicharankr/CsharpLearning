using System;

namespace CsharpLearning
{
    public interface IUnderstandingInterfaces
    {
        // interface members
        void Display();

        void GetValues(int c, int d);

        double Addition();
    }

    internal class UnderstandingInterfaces : IUnderstandingInterfaces
    {
        private int intA;
        private int intB;
        public int intAmount;

        public void GetValues(int c, int d)
        {
            intA = c;
            intB = d;
        }

        public double Addition()
        {
            return intAmount = intA + intB;
        }

        public void Display()
        {
            Console.WriteLine("Operand A : {0}", intA);
            Console.WriteLine("operand B: {0}", intB);
            Console.WriteLine("Total: {0}", Addition());
        }
    }
}