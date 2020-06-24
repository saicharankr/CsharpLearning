using System;

namespace CsharpLearning
{
    public class DelegatesUnderstanding
    {
        private delegate int Numbers(int a, int b);

        private int Total = 0;

        public int Sum(int a, int b)
        {
            return Total = a + b;
        }

        public int Multiply(int a, int b)
        {
            return Total = a * b;
        }

        public int Return()
        {
            return Total;
        }

        public void ToMain()
        {
            Numbers n;
            Numbers n1 = new Numbers(Sum);
            Numbers n2 = new Numbers(Multiply);

            n = n1;
            // n += n2;

            n(4, 5);
            Console.WriteLine(" Multi casting {0} ", Return());

            n1(4, 10);
            Console.WriteLine("Sum of numbers {0}", Return());

            n2(5, 6);
            Console.WriteLine("Multiplication of numbers {0}", Return());
        }
    }
}