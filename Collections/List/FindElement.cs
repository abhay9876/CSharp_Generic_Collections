/*Find the Nth Element from the End
Given a singly linked list (LinkedList), find the Nth element from the end
without calculating its size.
Example:
Input: [A, B, C, D, E], N=2
Output: D*/

namespace List
{
    class NthElement
    {
        public static void Solution()
        {
            LinkedList<char> element = new LinkedList<char>();
            element.AddLast('A');
            element.AddLast('B');
            element.AddLast('C');
            element.AddLast('D');
            element.AddLast('E');
            Console.WriteLine("List  : ");
            foreach (var v in element)
            {
                Console.Write(" " + v);
            }
            Console.WriteLine();

            int n = 2;
            int count = element.Count - n;
            LinkedListNode<char> head = element.First;
            int i = 0;
            while (i < count)
            {
                head = head.Next;
                i++;
            }

            Console.WriteLine(head.Value);

        }
    }
}