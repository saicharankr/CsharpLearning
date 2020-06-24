using System;

namespace CsharpLearning
{
    internal delegate void NumberChanger(int n);

    internal class AnonymousMethods
    {
        private static int num = 10;

        public static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("Named Method Addition : {0}", num);
        }

        public static void MultNum(int q)
        {
            num *= q;
            Console.WriteLine("Named Method Mutiplication: {0}", num);
        }

        public static int getNum()
        {
            return num;
        }

        public void ToMain()
        {
            //create delegate instances using anonymous method
            NumberChanger nc = delegate (int x)
            {
                int a = 100;

                Console.WriteLine("Anonymous Method: {0}", a += x);
            };

            //calling the delegate using the anonymous method
            nc(10);

            //instantiating the delegate using the named methods
            nc = new NumberChanger(AddNum);

            //calling the delegate using the named methods
            nc(5);

            //instantiating the delegate using another named methods
            nc = new NumberChanger(MultNum);

            //calling the delegate using the named methods
            nc(2);
            Console.ReadKey();
        }
    }
}