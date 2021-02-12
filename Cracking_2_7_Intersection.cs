namespace Practice
{
    using System;
    using System.Collections.Generic;

    public static class Cracking_2_7_Intersection
    {
        public static void Go()
        {
            Console.Out.WriteLine("\nIntersection");

            var l1 = LinkedList<string>.FromEnumerable(new List<string> { "1A", "1B", "1C" });
            var l2 = LinkedList<string>.FromEnumerable(new List<string> { "2A", "2B" });
            var l3 = LinkedList<string>.FromEnumerable(new List<string> { "3A", "3B" });

            l1.Head.Next.Next.Next = l3.Head;
            l2.Head.Next.Next = l3.Head;

            Util.Print("Intersecting", "3A", Solution(l1, l2).Value);
        }

        public static Node<T> Solution<T>(LinkedList<T> l1, LinkedList<T> l2)
        {
            if (l1 == null || l1.Head == null) return null;
            if (l2 == null || l2.Head == null) return null;
            if (l1.Head == l2.Head) return l1.Head;

            var seen = new HashSet<Node<T>>();
            var n1 = l1.Head;
            var n2 = l2.Head;

            while (n1.Next != null && n2.Next != null)
            {
                if (seen.Contains(n1.Next)) return n1.Next;
                if (seen.Contains(n2.Next)) return n2.Next;
                seen.Add(n1.Next);
                seen.Add(n2.Next);
                n1 = n1.Next;
                n2 = n2.Next;
            }

            return null;
        }
    }
}