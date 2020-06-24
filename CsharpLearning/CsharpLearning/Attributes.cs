using System;

namespace CsharpLearning
{
    [DebugInfo(1, "cherry", "20/01/2020", Message = "Attributes Demo")] //Custom created Attribute
    public class Attributes
    {
        #region PreDefined Attributes

        [Obsolete("Don't use OldMethod, use NewMethod instead", true)]
        public void OldMethod()
        {
            Console.WriteLine("It is the old method");
        }

        public void NewMethod()
        {
            Console.WriteLine("It is the new method");
        }

        public void ToMain()
        {
            //OldMethod();
            NewMethod();
        }

        #endregion PreDefined Attributes
    }
}