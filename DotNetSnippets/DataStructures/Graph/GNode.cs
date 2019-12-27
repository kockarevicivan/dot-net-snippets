using System;
using System.Collections.Generic;

namespace DotNetSnippets.DataStructures.Graph
{
    public class GNode
    {
        public int Value { get; set; }
        public List<GNode> Siblings { get; set; }

        public int PathTo { get; set; }

        public GNode(int value)
        {
            this.Value = value;
            this.Siblings = new List<GNode>();
            this.PathTo = 0;
        }

        public GNode(int value, List<GNode> siblings)
        {
            this.Value = value;
            this.Siblings = siblings;
            this.PathTo = 0;
        }
    }
}
