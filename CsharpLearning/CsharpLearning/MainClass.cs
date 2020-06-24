using System;

namespace CsharpLearning
{
    internal class MainClass
    {
        private static void Main(string[] args)
        {
            //loops loop = new loops();
            //loop.PrintPrime(10);

            //Class1 class1 = new Class1();
            //Console.WriteLine(class1.DigitalRoot(45));

            //Square sq = new Square();
            //sq.AcceptDetails();
            //sq.Display();

            //DataTypesAndTypecasting dataTypesAndTypecasting = new DataTypesAndTypecasting();
            //Console.WriteLine(dataTypesAndTypecasting.Sum());

            //AreaOfCircle areaOfCircle = new AreaOfCircle();
            //areaOfCircle.GetRadius();
            //areaOfCircle.Display();

            //PassByValue passByValue = new PassByValue();
            //int a = 100;
            //int b = 200;

            //Console.WriteLine("Before swap, value of a : {0}", a);
            //Console.WriteLine("Before swap, value of b : {0}", b);

            ///* calling a function to swap the values */
            //passByValue.swap(a, b);

            //Console.WriteLine("After swap, value of a : {0}", a);
            //Console.WriteLine("After swap, value of b : {0}", b);

            ////Pass by reference
            //PassbyReference passbyReference = new PassbyReference();
            //int c = 100;
            //int d = 200;

            //Console.WriteLine("Before swap, value of a : {0}", c);
            //Console.WriteLine("Before swap, value of b : {0}", d);

            ///* calling a function to swap the values */
            //passbyReference.swap(ref c, ref d);

            //Console.WriteLine("After swap, value of a : {0}", c);
            //Console.WriteLine("After swap, value of b : {0}", d);

            //* local variable definition
            //int e = 100;

            //Console.WriteLine("Before method call, value of a : {0}", e);

            //Pass_ParameterByOutput pass_ParameterByOutput = new Pass_ParameterByOutput();
            ///* calling a function to get the value

            //pass_ParameterByOutput.getValue(out e);

            //Console.WriteLine("After method call, value of a : {0}", e);
            //Console.ReadLine();
            //Console.ReadLine();

            //UnderstandingArrays understandingArrays = new UnderstandingArrays();
            //understandingArrays.Arrays();
            //understandingArrays.MdArray();
            //// an int array with 5 elements
            //int[] balance = new int[] { 1000, 2, 3, 17, 50 };
            //double avg;

            //// pass pointer to the array as an argument
            //avg = understandingArrays.AuArray(balance, 5);

            ////output the returned value
            //Console.WriteLine("Average value is: {0} ", avg);

            //UnderstandingNullables understandingNullables = new UnderstandingNullables();
            //understandingNullables.UnNullables();

            //UnderstandingStructures understandingStructures = new UnderstandingStructures();
            //understandingStructures.UsingStruct();

            //Polymorphism polymorphism = new Polymorphism();
            //polymorphism.Demo(1);

            ////operator overLoading
            //Box box1 = new Box();
            //Box box2 = new Box();
            //Box box3 = new Box();

            //double Volume = 0.0;

            //box1.SetParameters(2.0, 4.0, 5.0);
            //box2.SetParameters(4.0, 5.0, 2.0);

            //Console.WriteLine("Box 1 volume : {0}", box1.Volume());
            //Console.WriteLine("Box 2 volume : {0}", box2.Volume());

            ////Operator overloaded object addition
            //box3 = box1 + box2;

            //Console.WriteLine("Box 3 volume : {0}", box3.Volume());

            //Interfaces
            //UnderstandingInterfaces understandingInterfaces = new UnderstandingInterfaces();
            //understandingInterfaces.Transaction()

            //PreProcessingDirectives preProcessingDirectives = new PreProcessingDirectives();
            //preProcessingDirectives.PpdDemo();

            //TryCatch tryCatch = new TryCatch();
            //tryCatch.Input();

            //FileOp op = new FileOp();
            //op.CreateFile();

            //RegexUnderstanding rg = new RegexUnderstanding();
            //rg.Regex();
            //rg.GreedyRegex();
            //Console.Write("");
            //rg.LazyRegex();
            //rg.LookAround();

            //DelegatesUnderstanding de = new DelegatesUnderstanding();
            //de.ToMain();

            //UnderstandingEvents events = new UnderstandingEvents();
            //events.ToMain();

            //UnderstandingGeneric<int> intGeneric = new UnderstandingGeneric<int>(5);
            //UnderstandingGeneric<char> charGeneric = new UnderstandingGeneric<char>(5);

            //Console.WriteLine("Printing integer Type Items ");
            //for (int i = 0; i < 5; i++)
            //{
            //    intGeneric.AddItems(i, i + 5);
            //    Console.Write(intGeneric.GetItems(i));
            //}
            //Console.WriteLine(" ");
            //Console.WriteLine("Printing Character Type Items ");
            //for (int i = 0; i < 5; i++)
            //{
            //    charGeneric.AddItems(i, (char)(i + 65));
            //    Console.Write(charGeneric.GetItems(i));
            //}

            //Generic2 generic = new Generic2();
            //generic.ToMain();

            //AnonymousMethods anonymous = new AnonymousMethods();
            //anonymous.ToMain();

            //MultiThreading threading = new MultiThreading();
            //threading.ToMain();

            //Reflections reflections = new Reflections();
            ////reflections.ToMain();
            //reflections.Libinfo();

            //Properties properties = new Properties();
            //properties.ToMain();

            //Indexers indexers = new Indexers();
            //indexers.ToMain();

            Collections collections = new Collections();
            collections.ToMain();
        }
    }
}