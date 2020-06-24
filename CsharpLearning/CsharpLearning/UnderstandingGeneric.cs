using System;

namespace CsharpLearning
{
    public class UnderstandingGeneric<T>
    {
        private T[] tArray;

        public UnderstandingGeneric(int iSize)
        {
            tArray = new T[iSize + 1];
        }

        public T GetItems(int index)
        {
            return tArray[index];
        }

        public T AddItems(int index, T Item)
        {
            return tArray[index] = Item;
        }
    }
}