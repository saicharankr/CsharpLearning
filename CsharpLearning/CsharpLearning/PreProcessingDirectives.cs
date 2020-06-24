#define Cherry

//#undef Cherry

using System;

namespace CsharpLearning
{
    public class PreProcessingDirectives
    {
        #region "Starting the program"

        public void PpdDemo()
        {
#if (Cherry)
            Console.WriteLine("Cherry is defined");
#else
            Console.WriteLine("Cherry is not defined");
            // using #warning to display message that
            // none of the symbols were found
#warning"No Symbols found"

            // Generating user defined error
#error "Check use of preprocessors"
#endif
        }

        #endregion "Starting the program"
    }
}