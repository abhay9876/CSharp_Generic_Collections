/*Remove Duplicates While Preserving Order
Remove duplicate elements from a list while maintaining the original order.
Example:
Input: [3, 1, 2, 2, 3, 4]
Output: [3, 1, 2, 4]*/

namespace List
{
    class RemoveDuplicateElement
    {
        public static void Solution()
        {
            List<int> element = new List<int>() { 3, 1, 2, 2, 3, 4 };
            Console.WriteLine("List Before Removing Duplicates : ");
            foreach (int i in element)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();

            Dictionary<int, int> result = RemoveDuplicate(element);

            Console.WriteLine("List After Removing Duplicates : ");
            foreach (var i in result)
            {
                Console.Write($" {i.Key}");
            }
            Console.WriteLine();
        }

        public static Dictionary<int, int> RemoveDuplicate(List<int> list)
        {
            Dictionary<int, int> res = new Dictionary<int, int>();

            foreach (var v in list)
            {
                if (res.ContainsKey(v))
                {
                    res[v]++;
                }
                else
                {
                    res[v] = 1;
                }
            }

            return res;
        }
    }
}