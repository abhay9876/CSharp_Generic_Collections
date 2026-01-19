/*Union and Intersection of Two Sets
Compute the union and intersection of two sets.
Example:
Set1: {1, 2, 3}, Set2: {3, 4, 5}
Output:
Union: {1, 2, 3, 4, 5}
Intersection: {3}*/


using System;
using System.Collections.Generic;

namespace Set
{
    class UnionAndIntersect
    {
        public static void Check()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

            Console.WriteLine("Set 1 and Set 2  : ");
            Console.WriteLine(string.Join(" ,", set1));
            Console.WriteLine(string.Join(" ,", set2));
            Console.WriteLine("Union : ");
            HashSet<int> union = new HashSet<int>(set1);
            union.UnionWith(set2);
            Console.WriteLine(string.Join(" ,", union));

            Console.WriteLine("Intersect : ");
            HashSet<int> intersect = new HashSet<int>(set1);
            intersect.IntersectWith(set2);
            Console.WriteLine(string.Join(" ,", intersect));

        }
    }
}