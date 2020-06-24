namespace CsharpLearning
{
    internal class Pass_ParameterByOutput
    {
        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }
    }
}