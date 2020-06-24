using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearning
{
    internal class Indexers
    {
        static public int size = 10;
        private string[] namelist = new string[size];

        public Indexers()
        {
            for (int i = 0; i < size; i++)
            {
                namelist[i] = "N. A.";
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < size)
                {
                    return namelist[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (index >= 0 && index < size)
                {
                    namelist[index] = value;
                }
            }
        }

        public int this[string name]
        {
            get
            {
                int index = 0;

                if (namelist[index] == name)
                {
                    return index;
                }
                index++;

                return index;
            }
        }

        public void ToMain()
        {
            Indexers names = new Indexers();
            names[0] = "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Davinder";
            names[5] = "Sunil";
            names[6] = "Rubic";
            names[7] = "Davinder";
            names[8] = "Sunil";
            names[9] = "Rubic";
            //names[10] = "sunny";

            //using the first indexer with int parameter
            for (int i = 0; i < Indexers.size; i++)
            {
                Console.WriteLine(names[i]);
            }

            //using the second indexer with the string parameter
            Console.WriteLine("To Find the the index of the Name , Enter name below ");
            string name = Console.ReadLine();
            Console.WriteLine(names[name]);
            Console.ReadKey();
        }
    }
}