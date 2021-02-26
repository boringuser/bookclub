namespace Practice
{
    using System;
    using System.Collections.Generic;

    public class GraphNode
    {
        public int Value { get; set; }

        public bool Visited { get; set; }

        public List<GraphNode> Neighbors { get; private set; }

        public GraphNode()
        {
            this.Neighbors = new List<GraphNode>();
        }
    }
}