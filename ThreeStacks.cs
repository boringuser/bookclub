namespace Practice
{
    using System;

    public class ThreeStacks
    {
        private const int MaxSize = 5;
        private readonly int[] data = new int[MaxSize * 3];
        private readonly int[] size = new int[3];

        public void Push(int s, int val)
        {
            if (size[s] == MaxSize) throw new Exception("Stack full");
            data[(s * MaxSize) + size[s]] = val;
            size[s] = size[s] + 1;
        }

        public int Peek(int s)
        {
            if (size[s] == 0) throw new Exception("Stack empty");
            return data[(s * MaxSize) + size[s] - 1];
        }
        public int Pop(int s)
        {
            int val = Peek(s);
            size[s] = size[s] - 1;
            return val;
        }

        public bool IsEmpty(int s)
        {
            return size[s] == 0;
        }

    }
}