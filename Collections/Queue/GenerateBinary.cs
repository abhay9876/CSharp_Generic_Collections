/*Generate Binary Numbers Using a Queue
Generate the first N binary numbers using a queue.
Example:
Input: N=5
Output: {"1", "10", "11", "100", "101"}*/


namespace Queue
{
    class GenerateBinary
    {
        public static void Solution()
        {
            int N = 5;
            Queue<string> q = new Queue<string>();

            q.Enqueue("1");

            for (int i = 1; i <= N; i++)
            {
                string current = q.Dequeue();
                Console.Write(current + " ");

                q.Enqueue(current + "0");
                q.Enqueue(current + "1");
            }
        }
    }
}