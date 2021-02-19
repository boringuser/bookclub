namespace Practice
{
    using System.Collections.Generic;

    public class MyQueue<T>
    {
        private readonly Stack<T> items = new Stack<T>();
        private readonly Stack<T> temp = new Stack<T>();

        public void Add(T item)
        {
            this.items.Push(item);
        }

        public bool IsEmpty()
        {
            T i;
            return this.items.Count == 0;
        }

        public T Peek()
        {
            return this.GetHeadItem(false);
        }

        public T Pop()
        {
            return this.GetHeadItem(true);
        }

        private T GetHeadItem(bool remove)
        {
            T ret = default(T);

            while (this.items.Count > 0)
            {
                ret = this.items.Pop();
                if (this.items.Count > 0 || !remove)
                {
                    this.temp.Push(ret);
                }
            }

            while (this.temp.Count > 0)
            {
                this.items.Push(this.temp.Pop());
            }

            return ret;
        }
    }
}
