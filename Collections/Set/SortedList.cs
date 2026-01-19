/*Convert a Set to a Sorted List
Convert a HashSet<int> into a sorted list in ascending order.
Example:
Input: {5, 3, 9, 1}
Output: [1, 3, 5, 9]*/


namespace Set
{
    class SortedList
    {
        public static void Convert()
        {
            HashSet<int> set = new HashSet<int> { 5, 3, 9, 1 };
            List<int> list = new List<int>(set);

            list.Sort();
            Console.WriteLine("Sorted List " + string.Join(" ,", list));
        }
    }
}