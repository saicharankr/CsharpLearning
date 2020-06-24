namespace CsharpLearning
{
    public class Box
    {
        private double Length;   // Length of a box
        private double Breadth;  // Breadth of a box
        private double Height;   // Height of a box

        public void SetParameters(double length, double breadth, double height)
        {
            Length = length;
            Breadth = breadth;
            Height = height;
        }

        public double Volume()
        {
            return Length * Breadth * Height;
        }

        public static Box operator +(Box a, Box b)
        {
            Box box = new Box();
            box.Length = a.Length + b.Length;
            box.Height = a.Height + b.Height;
            box.Breadth = a.Breadth + b.Breadth;

            return box;
        }
    }
}