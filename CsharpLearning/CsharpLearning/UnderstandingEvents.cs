using System;

namespace CsharpLearning
{
    public delegate string Greetings(string r);

    public class UnderstandingEvents
    {
        public event Greetings Greet;

        public event Greetings Exit;

        public UnderstandingEvents()
        {
            Greet += new Greetings(WelcomeUser);

            Exit += new Greetings(ExitUser);
        }

        public string WelcomeUser(string UserName)
        {
            return "Welcome " + UserName;
        }

        public string ExitUser(string username)
        {
            return "Thank You For Visisting Us " + username;
        }

        public void ToMain()
        {
            UnderstandingEvents events = new UnderstandingEvents();

            Console.WriteLine("Click A To enter application");

            while (Console.ReadKey().Key == ConsoleKey.A)
            {
                Console.WriteLine("");
                Console.WriteLine(events.Greet("Sai charan"));
            }

            Console.WriteLine("Click Q To Exit application");

            while (Console.ReadKey().Key == ConsoleKey.Q)
            {
                Console.WriteLine("");
                Console.WriteLine(events.Exit("Sai charan"));
            }
        }
    }
}