using System.Linq;
using System.Collections.Generic;

namespace DotNetSnippets.DataStructures.Graph
{
    public class Graph
    {
        private Dictionary<int, GNode> _nodeDictionary = new Dictionary<int, GNode>();

        // Default adjacency matrix, for testing purposes.
        private int[,] _adjacencyMatrix;


        public Graph(int[,] adjacencyMatrix)
        {
            _adjacencyMatrix = adjacencyMatrix;

            for (int i = 0; i < _adjacencyMatrix.Length; i++)
            {
                GNode newNode = new GNode(i);

                for (int j = 0; j < _adjacencyMatrix.Length; j++)
                {
                    GNode sibling;

                    if (_nodeDictionary.ContainsKey(j))
                    {
                        sibling = _nodeDictionary[j];
                    }
                    else
                    {
                        sibling = new GNode(j);
                        _nodeDictionary.Add(j, sibling);
                    }
                    
                    newNode.Siblings.Add(sibling);
                }
            }
        }


        public GNode BreadthFirstSearch (int value, int start)
        {
            List<GNode> alreadyVisited = new List<GNode>();
            Queue<GNode> toVisit = new Queue<GNode>();

            toVisit.Enqueue(_nodeDictionary[start]);

            while(toVisit.Count > 0)
            {
                GNode currentNode = toVisit.Dequeue();

                if (alreadyVisited.Contains(currentNode))
                    continue;

                if (currentNode.Value == value)
                    return currentNode;

                currentNode.Siblings.ForEach(s => toVisit.Enqueue(s));

                alreadyVisited.Add(currentNode);
            }

            return null;
        }

        public GNode DepthFirstSearch(int value, int start)
        {
            List<GNode> alreadyVisited = new List<GNode>();
            Stack<GNode> toVisit = new Stack<GNode>();

            toVisit.Push(_nodeDictionary[start]);

            while (toVisit.Count > 0)
            {
                GNode currentNode = toVisit.Pop();

                if (alreadyVisited.Contains(currentNode))
                    continue;

                if (currentNode.Value == value)
                    return currentNode;

                currentNode.Siblings.ForEach(s => toVisit.Push(s));

                alreadyVisited.Add(currentNode);
            }

            return null;
        }

        public GNode DijkstraSearch(int value, int start)
        {
            List<GNode> alreadyVisited = new List<GNode>();
            List<GNode> toVisit = new List<GNode>();

            toVisit.Add(_nodeDictionary[start]);

            while (toVisit.Count > 0)
            {
                GNode currentNode = toVisit.First();
                toVisit.RemoveAt(0);

                if (alreadyVisited.Contains(currentNode))
                    continue;

                if (currentNode.Value == value)
                    return currentNode;

                currentNode.Siblings.ForEach(s => {
                    s.PathTo = currentNode.PathTo + _adjacencyMatrix[currentNode.Value, s.Value];
                    toVisit.Add(s);
                });

                toVisit.OrderBy(n => n.PathTo);

                alreadyVisited.Add(currentNode);
            }

            return null;
        }

        public GNode GreedyBestFirstSearch(int value, int start, int[,] heuristicsMatrix)
        {
            List<GNode> alreadyVisited = new List<GNode>();
            List<GNode> toVisit = new List<GNode>();

            toVisit.Add(_nodeDictionary[start]);

            while (toVisit.Count > 0)
            {
                GNode currentNode = toVisit.First();
                toVisit.RemoveAt(0);

                if (alreadyVisited.Contains(currentNode))
                    continue;

                if (currentNode.Value == value)
                    return currentNode;

                currentNode.Siblings.ForEach(s => {
                    s.PathTo = heuristicsMatrix[currentNode.Value, s.Value];
                    toVisit.Add(s);
                });

                toVisit.OrderBy(n => n.PathTo);

                alreadyVisited.Add(currentNode);
            }

            return null;
        }

        public GNode AStarSearch(int value, int start, int[,] heuristicsMatrix)
        {
            List<GNode> alreadyVisited = new List<GNode>();
            List<GNode> toVisit = new List<GNode>();

            toVisit.Add(_nodeDictionary[start]);

            while (toVisit.Count > 0)
            {
                GNode currentNode = toVisit.First();
                toVisit.RemoveAt(0);

                if (alreadyVisited.Contains(currentNode))
                    continue;

                if (currentNode.Value == value)
                    return currentNode;

                currentNode.Siblings.ForEach(s => {
                    s.PathTo = currentNode.PathTo + _adjacencyMatrix[currentNode.Value, s.Value] + heuristicsMatrix[currentNode.Value, s.Value];
                    toVisit.Add(s);
                });

                toVisit.OrderBy(n => n.PathTo);

                alreadyVisited.Add(currentNode);
            }

            return null;
        }
    }
}
