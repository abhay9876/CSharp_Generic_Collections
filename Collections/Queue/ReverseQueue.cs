/*Reverse a Queue
Reverse the elements of a queue using only queue operations.
Example:
Input: [10, 20, 30]
Output: [30, 20, 10]*/


namespace Queue
{
    class ReverseQueue
    {
        public static void Solution()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Reverse(queue);
            Console.WriteLine(string.Join(" ,", queue));


        }

        public static void Reverse(Queue<int> q)
        {
            if (q.Count == 0)
            {
                return;
            }

            int front = q.Dequeue();
            Reverse(q);
            q.Enqueue(front);
        }
    }
}