using System;
using System.Threading;

/*<summery>
Threads are lightweight processes. One common example of
use of thread is implementation of concurrent programming
by modern operating systems. Use of threads saves wastage
of CPU cycle and increase efficiency of an application.

    1.The Unstarted State
    2.The Ready State
    3.The Not Runnable State .
    4.The Dead State
<summery>*/

namespace CsharpLearning
{
    internal class MultiThreading
    {
        public static void ChildThread()
        {
            Console.WriteLine("Child thread starts");

            #region managing threads

            // the thread is paused for 5000 milliseconds
            int sleepfor = 3000;

            Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
            for (int loading = 0; loading <= 10; loading++)
            {
                Thread.Sleep(sleepfor);
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.WriteLine("Child thread resumes");

            #endregion managing threads
        }

        public void ToMain()
        {
            ThreadStart childthread1 = new ThreadStart(ChildThread);

            Console.WriteLine("In ToMain: Creating the Child thread");

            Thread childThread2 = new Thread(childthread1);
            childThread2.Start();

            Console.WriteLine("Back to main thread");

            Console.ReadKey();
        }
    }
}