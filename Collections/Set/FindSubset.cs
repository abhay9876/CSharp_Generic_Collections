/*Find Subsets
Check if one set is a subset of another.
Example:
Input: {2, 3}, {1, 2, 3, 4}
Output: true*/

namespace Set
{
    class FindSubset
    {
        public static void Find()
        {
            HashSet<int> set1 = new HashSet<int> { 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4 };

            bool equal = set1.IsSubsetOf(set2);

            Console.WriteLine("Set 1 is a subset of set2 : " + equal);
        }
    }
}