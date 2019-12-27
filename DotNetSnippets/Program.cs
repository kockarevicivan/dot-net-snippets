using DotNetSnippets.Algorithms;
using DotNetSnippets.DataStructures.DoubleLinkedList;
using DotNetSnippets.DataStructures.SingleLinkedList;

namespace DotNetSnippets
{
    class Program
    {
        private SortingService _sortingService = new SortingService();
        private RandomService _randomService = new RandomService();

        static void Main(string[] args)
        {
            TestSLL();
            TestDLL();
        }
        
        static void TestSLL()
        {
            SingleLinkedList<int> myList = new SingleLinkedList<int>();

            myList.Add(345).Add(-26).Add(0).Add(0).Add(1000);

            var result = myList.Search(1000);

            myList.Remove(345).Remove(0).Remove(1000);

            foreach (var item in myList)
                System.Console.WriteLine(item);
        }

        static void TestDLL()
        {
            DoubleLinkedList<int> myList = new DoubleLinkedList<int>();

            myList.Add(345).Add(-26).Add(0).Add(0).Add(1000);

            var result = myList.Search(1000);

            myList.Remove(345).Remove(0).Remove(1000);

            foreach (var item in myList)
                System.Console.WriteLine(item);
        }
    }
}
