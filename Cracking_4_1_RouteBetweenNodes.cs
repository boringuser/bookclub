namespace Practice
{
    using System;
    using System.Collections.Generic;

    public static class Cracking_4_1_RouteBetweenNodes
    {
        private enum QueueId
        {
            None = 0,
            Q1 = 1,
            Q2 = 2
        };

        public static void Go()
        {
            Console.Out.WriteLine("\nRoute between nodes");

            List<GraphNode> nodes = new List<GraphNode>();

            for (int i = 0; i < 6; i++)
            {
                nodes.Add(new GraphNode() { Value = i });
            }

            nodes[5].Neighbors.Add(nodes[3]);
            nodes[5].Neighbors.Add(nodes[4]);
            nodes[3].Neighbors.Add(nodes[4]);
            nodes[0].Neighbors.Add(nodes[3]);
            nodes[0].Neighbors.Add(nodes[2]);
            nodes[0].Neighbors.Add(nodes[1]);
            nodes[1].Neighbors.Add(nodes[2]);

            Util.Print("Route from 0 to 4", true, Solution(nodes[0], nodes[4]));
            ResetVisited(nodes);
            Util.Print("Route from 1 to 4", false, Solution(nodes[1], nodes[4]));
        }

        private static void ResetVisited(List<GraphNode> nodes)
        {
            foreach (GraphNode n in nodes) n.Visited = false;
        }

        private static bool Solution(GraphNode n1, GraphNode n2)
        {
            if (n1 == null || n2 == null) return false;

            var q = new Queue<GraphNode>();

            q.Enqueue(n1);

            while (q.Count > 0)
            {
                GraphNode n = q.Dequeue();

                foreach(GraphNode neighbor in n.Neighbors)
                {
                    if (neighbor == n2) return true;
                    if (!neighbor.Visited) q.Enqueue(neighbor);
                }
            }

            return false;
        }
    }
}