/*Symmetric Difference
Find the symmetric difference (elements present in either set but not both).
Example:
Input: {1, 2, 3}, {3, 4, 5}
Output: {1, 2, 4, 5}*/

using System;
using System.Collections.Generic;

namespace Set
{
    class SymmetricDifference
    {
        public static void Check()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

            Console.WriteLine("Set 1 and Set 2  : ");
            Console.WriteLine(string.Join(" ,", set1));
            Console.WriteLine(string.Join(" ,", set2));
            Console.WriteLine("Symmetric Difference : ");
            set1.SymmetricExceptWith(set2);
            Console.WriteLine(string.Join(" ,", set1));

        }
    }
}