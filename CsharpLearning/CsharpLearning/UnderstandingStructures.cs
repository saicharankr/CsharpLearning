using System;

namespace CsharpLearning
{
    // Defining a structure
    public struct StudentDetails
    {
        public int strutStudentID;
        public string structStudentName;
        public string structStudentClass;

        public int[] structStudentMarks;

        // Constructor in structures (Parameterizied constructor)
        public StudentDetails(int studentId, string studentName, string studentClass, int[] studentMarks)
        {
            strutStudentID = studentId;
            structStudentName = studentName;
            structStudentClass = studentClass;
            structStudentMarks = studentMarks;
        }

        //structures can have methods/functions
        public void Display()
        {
            Console.WriteLine("From a Method in Structure");

            Console.WriteLine("StudentID : {0}", strutStudentID);
            Console.WriteLine("StudentName : {0}", structStudentName);
            Console.WriteLine("StudentClass : {0}", structStudentClass);

            for (int i = 0; i < structStudentMarks.Length; i++)
            {
                Console.WriteLine("Student 1 StudentMarks[{0}] :{1}", i, structStudentMarks[i]);
            }
        }
    };

    public class UnderstandingStructures
    {
        public void UsingStruct()
        {
            //structs can be instantiated without using the New operator
            StudentDetails Student1;

            // Parameterisized constuctor is intilized using a new keyword
            StudentDetails studentDetails = new StudentDetails(1, "Superman", "VII", new int[4] { 45, 56, 64, 45 });

            //Calling a method from structure
            studentDetails.Display();

            Student1.strutStudentID = 1;
            Student1.structStudentName = "Cherry";
            Student1.structStudentClass = "V";
            Student1.structStudentMarks = new int[4] { 45, 23, 45, 56 };

            Console.WriteLine("printing From a class ");

            Console.WriteLine("Student 1 StudentID : {0}", Student1.strutStudentID);
            Console.WriteLine("Student 1 StudentName : {0}", Student1.structStudentName);
            Console.WriteLine("Student 1 subject : {0}", Student1.structStudentClass);

            for (int i = 0; i < Student1.structStudentMarks.Length; i++)
            {
                Console.WriteLine("Student 1 StudentMarks[{0}] :{1}", i, Student1.structStudentMarks[i]);
            }

            Console.ReadLine();
        }
    }
}