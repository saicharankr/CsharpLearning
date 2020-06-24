using System;

namespace CsharpLearning
{
    public class UnderstandingNullables
    {
        public void UnNullables()
        {
            double? num1 = null; // ? is a nullable operator
            double? num2 = 3.14157;
            double num3;

            num3 = num1 ?? 5.34;  // ?? Null Coalescing Operator
            /*If the value of the first operand is null,
              then the operator returns the value of the second operand,
              otherwise it returns the value of the first operand. */
            Console.WriteLine(" Value of num3: {0}", num3);

            num3 = num2 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);
            Console.ReadLine();
        }
    }
}