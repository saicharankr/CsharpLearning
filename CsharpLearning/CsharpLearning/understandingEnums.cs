using System;

namespace CsharpLearning
{
    public class understandingEnums
    {
        //An enumeration is a set of named integer constants
        public enum Days
        { Sun, Mon, tue, Wed, thu, Fri, Sat };

        public void Display()
        {
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;

            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);
            Console.ReadKey();
        }
    }
}