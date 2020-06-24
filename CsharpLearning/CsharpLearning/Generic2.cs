using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearning
{
    internal class Generic2
    {
        public (E, E) Swap<E>(E tItem1, E tItem2)
        {
            //E temp;
            //temp = tItem1;
            //tItem1 = tItem2;
            //tItem2 = temp;

            return (tItem2, tItem1);
        }

        public void ToMain()
        {
            int a, b;
            char c, d;
            a = 10;
            b = 20;
            c = 'I';
            d = 'V';

            //display values before swap:
            Console.WriteLine("");
            Console.WriteLine("_____Printing from Generic2 class___i.e To understand Generic method");
            Console.WriteLine("Int values before calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Char values before calling swap:");
            Console.WriteLine("c = {0}, d = {1}", c, d);

            //call swap

            (int, int) A = Swap<int>(a, b);

            (char, char) B = Swap<char>(c, d);

            //display values after swap:
            Console.WriteLine("Int values after calling swap:");
            Console.WriteLine("a = {0}, b = {1}", A.Item1, A.Item2);

            Console.WriteLine("Char values after calling swap:");
            Console.WriteLine("c = {0}, d = {1}", B.Item1, B.Item2);

            Console.ReadKey();
        }
    }
}