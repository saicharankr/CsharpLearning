using System;

namespace CsharpLearning
{
    public class UnderstandingArrays
    {
        public void Arrays()
        {
            int[] n = new int[10]; // n is an array of 10 integers

            // initialize elements of array n
            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            // accesing  each array element's value
            foreach (int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Element[{0}] = {1}", i, j);
            }
        }

        public void MdArray()
        {
            //an array with 5 rows and 2 columns
            int[,] a = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
            int i, j;

            // output each array element's value
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
                }
            }
        }

        // passing array as arguments to function

        public double AuArray(int[] arr, int size)
        {
            int i;
            double avg;
            int sum = 0;

            for (i = 0; i < size; ++i)
            {
                sum += arr[i];
            }
            avg = (double)sum / size;
            return avg;
        }

        //jagged array means array inside an array
        public void jaggedArray()
        {
            int[][] a = new int[][]{new int[]{0,0},new int[]{1,2},
            new int[]{2,4},new int[]{ 3, 6 }, new int[]{ 4, 8 } };
            int i, j;

            /* output each array element's value */
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0}][{1}] = {2}", i, j, a[i][j]);
                }
            }
            Console.ReadKey();
        }
    }
}