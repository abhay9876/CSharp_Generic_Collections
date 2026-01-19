using System;
using List;
using Set;
using Queue;
using Map;
namespace Collections
{
    class Program
    {
        public static void Main()
        {

            // --------------LIST------------------

            // Reverse List and LinkedList
            //ReverseList.Solution();
            // Find Frequency
            Frequency.Solution();

            // Rotate List With a Position
            RotateElement.Solution();

            // Remove Duplicate
            RemoveDuplicateElement.Solution();

            // Find Nth Element
            NthElement.Solution();


            // ------------------SET----------------

            // Check the equality of Set
            SetEqual.Check();

            // Union and Intersect
            UnionAndIntersect.Check();

            //Symmetric Difference
            SymmetricDifference.Check();

            // Sorted List
            SortedList.Convert();

            // Subset
            FindSubset.Find();


            //-------------Queue--------------

            // Reverse Queue
            ReverseQueue.Solution();

            // Generate Binary
            GenerateBinary.Solution();

            // PriorityQueue
            Hospital.Solution();


            //-----------MAP---------------
            FrequencyCounter.Counter();

            // InvertMap
            InvertMap.Invert();
        }
    }
}