namespace Practice
{
    using System;

    public static class Cracking_3_4_QueueViaStacks
    {
        public static void Go()
        {
            Console.Out.WriteLine("\nQueue via Stacks");

            var q = new MyQueue<int>();
            
            for (int i = 0; i < 5; i++)
            {
                q.Add(i);
            }

            for (int i = 0; i < 5; i++)
            {
                Util.Print("Queue via Stacks " + i, i, q.Pop());
            }

            Util.Print("Queue empty", true, q.IsEmpty());
        }


    }
}