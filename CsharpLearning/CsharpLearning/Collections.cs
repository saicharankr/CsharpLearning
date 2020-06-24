using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CsharpLearning
{
    internal class Collections
    {
        public void CollArrayList()
        {
            ArrayList arrayList = new ArrayList();

            Console.WriteLine("Adding some numbers to   ArrayList: Enter the Size of stack below ");

            int size = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                arrayList.Add(Int32.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Count: {0}", arrayList.Count);
            Console.Write("Content: ");
            foreach (int i in arrayList)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.Write("Sorted Content: ");
            arrayList.Sort();

            foreach (int i in arrayList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        public void CollHashable()
        {
            Hashtable ht = new Hashtable();

            ht.Add("001", "Zara Ali");
            ht.Add("002", "Abida Rehman");
            ht.Add("004", "Joe Holzner");
            ht.Add("003", "Mausam Benazir Nur");
            ht.Add("005", "M. Amlan");
            ht.Add("006", "M. Arif");
            ht.Add("007", "Ritesh Saikia");

            Console.WriteLine("Add student to list format ");
            string name = Console.ReadLine();
            if (ht.ContainsValue(name))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                ht.Add("008", name);
            }

            // Get a collection of the keys.
            ICollection key = ht.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
            Console.ReadKey();
        }

        public void CollDictionary()
        {
            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");

            for (int i = 0; i < dict.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                        dict.Keys.ElementAt(i),
                                                        dict[dict.Keys.ElementAt(i)]);
            }
        }

        public void CollSortedList()
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(002, "Zara Ali");
            sortedList.Add(001, "Abida Rehman");
            sortedList.Add(004, "Joe Holzner");
            sortedList.Add(003, "Mausam Benazir Nur");

            ICollection key = sortedList.Keys;

            foreach (int k in key)
            {
                Console.WriteLine(k + ": " + sortedList[k]);
            }
        }

        public void CollStack()
        {
            Stack st = new Stack();

            st.Push('A');
            st.Push('M');

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Removing values ");
            st.Pop();

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
        }

        public void CollQueue()
        {
            Queue q = new Queue();

            q.Enqueue('A');
            q.Enqueue('M');

            Console.WriteLine("Current queue: ");
            foreach (char c in q)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Removing some values ");
            char ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);

            Console.ReadKey();
        }

        public void ToMain()
        {
            Console.WriteLine("Understanding ArrayList");
            CollArrayList();
            Console.WriteLine("Understanding Hashable");
            CollHashable();
            Console.WriteLine("Understanding Dictionary");
            CollDictionary();
            Console.WriteLine("Understanding SortedList");
            CollSortedList();
            Console.WriteLine("Understanding Stack");
            CollStack();
            Console.WriteLine("Understanding Queue");
            CollQueue();
        }
    }
}