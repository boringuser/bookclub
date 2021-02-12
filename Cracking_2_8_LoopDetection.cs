namespace Practice
{
    using System;
    using System.Collections.Generic;

    public static class Cracking_2_8_LoopDetection
    {
        public static void Go()
        {
            Console.Out.WriteLine("\nLoop Detection");

            var linkedList = LinkedList<char>.FromEnumerable(new List<char> { 'A', 'B', 'C', 'D', 'E' });
            var e = linkedList.Head.Next.Next.Next.Next;
            var c = linkedList.Head.Next.Next;
            e.Next = c;

            Util.Print("A->B->C->D->E->C", c.Value, Solution(linkedList).Value);

        }

        public static Node<char> Solution(LinkedList<char> linkedList)
        {
            if (linkedList == null || linkedList.Head == null) return null;
            if (linkedList.Head.Next == null) return null;

            Node<char> slow = linkedList.Head;
            Node<char> fast = linkedList.Head.Next;

            while (slow != null && fast != null)
            {
                if (slow == fast) return slow;
                slow = slow.Next;
                fast = fast.Next;
                if (fast != null) fast = fast.Next;
            }

            return null;
        }
    }
}