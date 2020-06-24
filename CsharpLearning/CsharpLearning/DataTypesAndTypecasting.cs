using System;

namespace CsharpLearning
{
    public class DataTypesAndTypecasting
    {
        private string Number1 = "1";
        private string Number2 = "2";

        public int Sum()
        {
            return Convert.ToInt32(Number1) + Convert.ToInt32(Number2);
        }
    }
}