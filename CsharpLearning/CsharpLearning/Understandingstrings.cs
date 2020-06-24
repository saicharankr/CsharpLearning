using System;

namespace CsharpLearning
{
    internal class Understandingstrings
    {
        public void UnString()
        {
            string str1 = "This is test";
            string str2 = "This is text";
            char operation = 'C';
            switch (operation)
            {
                case 'C':
                    if (String.Compare(str1, str2) == 0)
                    {
                        Console.WriteLine(str1 + " and " + str2 + " are equal.");
                    }
                    else
                    {
                        Console.WriteLine(str1 + " and " + str2 + " are not equal.");
                    }
                    Console.ReadKey();
                    break;

                case 'S':

                    if (str1.Contains("test"))
                    {
                        Console.WriteLine("The sequence 'test' was found.");
                    }
                    Console.ReadKey();
                    break;

                default:
                    break;
            }
        }
    }
}