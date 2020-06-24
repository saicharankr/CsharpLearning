using System;

namespace CsharpLearning
{
    internal class TryCatch
    {
        private int result;

        public int Divide(int a, int b)
        {
            result = a / b;
            return result;
        }

        public void Input()
        {
            try
            {
                Divide(2, 0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e.Message);
                throw (new DivideByZeroException("You cannot divide a number by zero"));
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
    }
}