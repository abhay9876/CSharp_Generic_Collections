/*Rotate Elements in a List
Rotate the elements of a list by a given number of positions.
Example:
Input: [10, 20, 30, 40, 50], rotate by 2
Output: [30, 40, 50, 10, 20]*/

namespace List
{
    class RotateElement
    {
        public static void Solution()
        {
            List<int> list = new List<int>() { 10, 20, 30, 40, 50 };
            int pos = 2;

            // Print List Before Rotation
            Console.WriteLine("Origin List :");
            foreach (var i in list)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            Rotate(list, 0, pos - 1);
            Rotate(list, pos, list.Count - 1);
            Rotate(list, 0, list.Count - 1);

            // Print List After Rotation
            Console.WriteLine("After Rotation List :");
            foreach (var i in list)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
        }
        // Method to rotate List
        public static void Rotate(List<int> list, int start, int end)
        {
            int i = start;
            int j = end;
            while (i < j)
            {
                int temp = list[i];
                list[i] = list[j];
                list[j] = temp;

                i++;
                j--;
            }
        }
    }
}