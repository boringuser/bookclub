namespace Practice
{
    using System.Collections.Generic;

    public class LinkedList<T>
    {
        public static LinkedList<T> FromEnumerable(IEnumerable<T> values)
        {
            var enumerator = values.GetEnumerator();
            enumerator.MoveNext();
            var linkedList = new LinkedList<T>(new Node<T>(enumerator.Current));
            var node = linkedList.Head;

            while (enumerator.MoveNext())
            {
                node.Next = new Node<T>(enumerator.Current);
                node = node.Next;
            }

            return linkedList;
        }

        public LinkedList(Node<T> head)
        {
            this.Head = head;
        }

        public Node<T> Head { get; set; }
    }
}