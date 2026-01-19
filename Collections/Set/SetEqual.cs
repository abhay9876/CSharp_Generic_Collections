/*Check if Two Sets Are Equal
Compare two sets and determine if they contain the same elements, regardless
of order.
Example:
Set1: {1, 2, 3}, Set2: {3, 2, 1}
Output: true*/

using System;
using System.Collections.Generic;

namespace Set
{
    class SetEqual
    {
        public static void Check()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 2, 1 };

            bool equal = set1.SetEquals(set2);

            Console.WriteLine("Set 1 and Set 2 Both are equal : " + equal);

        }
    }
}