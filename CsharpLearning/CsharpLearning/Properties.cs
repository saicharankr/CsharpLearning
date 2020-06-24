using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearning
{
    public class Properties
    {
        private string code = "N.A";
        private string name = "not known";
        private int age = 0;

        // Declare a Code property of type string:
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        // Declare a Name property of type string:
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // Declare a Age property of type int:
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public override string ToString()
        {
            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
        }

        public void ToMain()
        {
            Properties p = new Properties();

            // Setting code, name and the age of the student 1
            p.Code = "001";
            p.Name = "Zara";
            p.Age = 9;
            Console.WriteLine("Student 1 Info: {0}", p);

            // Setting code, name and the age of the student 2
            p.Code = "002";
            p.Name = "Sunny";
            p.Age = 10;
            Console.WriteLine("Student 2 Info: {0}", p);
            Console.ReadKey();
        }
    }
}