using DotNetSnippets.Algorithms;
using DotNetSnippets.DataStructures.Graph;

namespace DotNetSnippets
{
    class Program
    {
        private SortingService _sortingService = new SortingService();

        static void Main(string[] args)
        {
            int[ , ] adjacencyMatrix = {
                { 0, 3, 0, 2, 0, 0, 0, 0, 4 },
                { 3, 0, 0, 0, 0, 0, 0, 4, 0 },
                { 0, 0, 0, 6, 0, 1, 0, 2, 0 },
                { 2, 0, 6, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 1, 0, 0, 0, 0, 8 },
                { 0, 0, 1, 0, 0, 0, 8, 0, 0 },
                { 0, 0, 0, 0, 0, 8, 0, 0, 0 },
                { 0, 4, 2, 0, 0, 0, 0, 0, 0 },
                { 4, 0, 0, 0, 8, 0, 0, 0, 0 }
            };

            Graph g = new Graph(adjacencyMatrix);

            var result = g.BreadthFirstSearch(4, 0);

        }
    }
}
