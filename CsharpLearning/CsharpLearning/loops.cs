using System;

namespace CsharpLearning
{
    public class loops
    {
        public void PrintPrime(int m)
        {
            int i, j;
            for (i = 2; i < m; i++)
            {
                for (j = 2; j <= (i / j); j++)
                {
                    if ((i % j) == 0)
                    {
                        break;
                    }
                }
                if (j > (i / j))
                {
                    Console.WriteLine("{0} is prime", i);
                }
            }
        }
    }
}