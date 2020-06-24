using System;
using System.Reflection;

namespace CsharpLearning
{
    [DebugInfo(1, "Charan", "20/05/2019", Message = "To Show Demo of typrof(Class)")]
    internal class Reflections
    {
        private int Total = 0;

        public void Addition(int a, int b)
        {
            Total = a + b;
        }

        [DebugInfo(1, "Charan", "20/05/2019", Message = "Unused Variable")] //Custom Attribute
        public void Display()
        {
            int abc = 0;
            Console.WriteLine("Sum of a and b is {0}", Total);
        }

        public void ToMain()
        {
            #region To know the type of attribute used to class and Display information

            MemberInfo info = typeof(Reflections);
            object[] attributes = info.GetCustomAttributes(true);

            for (int i = 0; i < attributes.Length; i++)
            {
                Console.WriteLine("attribute Type of class refections {0}", attributes[i]);
                Console.WriteLine("");

                DebugInfo dbi = (DebugInfo)attributes[i];

                if (null != dbi)
                {
                    Console.WriteLine("Bug no: {0}", dbi.BugNo);
                    Console.WriteLine("Developer: {0}", dbi.Developer);
                    Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                    Console.WriteLine("Remarks: {0}", dbi.Message);
                }
            }

            Console.WriteLine("");

            #endregion To know the type of attribute used to class and Display information
        }

        #region Reflection of external dll

        public void Libinfo()
        {
            Assembly asm = Assembly.LoadFrom(@"C:\Users\CS-9\Documents\HelperLibrary.dll");

            Type t = asm.GetType("HelperLibrary.Logger");

            Console.WriteLine("*******Contents in Assembly*********");
            Console.WriteLine("");
            Console.WriteLine("Information:{0}", asm.FullName);
            Type[] asminfo = asm.GetTypes();
            foreach (Type tp in asminfo)
            {
                Console.WriteLine("Type:{0}", tp);
            }

            Console.WriteLine("");
            Console.WriteLine("*********Field info*********");

            FieldInfo[] fld = t.GetFields();
            foreach (FieldInfo f in fld)
            {
                Console.WriteLine("-->{0}", f.Name);
            }

            Console.WriteLine("");
            Console.WriteLine("*********Methods*********");
            MethodInfo[] mth = t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (MethodInfo m in mth)
            {
                Console.WriteLine("-->{0}", m.Name);
            }
            Console.ReadKey();
        }

        #endregion Reflection of external dll
    }
}