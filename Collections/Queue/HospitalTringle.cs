/*Hospital Triage System
Simulate a hospital triage system using a PriorityQueue where patients with
higher severity are treated first.

Example:
Patients: [ ("John", 3), ("Alice", 5), ("Bob", 2) ]
Order: Alice, John, Bob*/

namespace Queue
{
    class Hospital
    {
        public static void Solution()
        {
            // PriorityQueue
            PriorityQueue<string, int> pq = new PriorityQueue<string, int>();
            // .NET PriorityQueue is MIN-HEAP by default,
            // so we insert negative severity for MAX-HEAP.
            pq.Enqueue("John", -3);
            pq.Enqueue("Alice", -5);
            pq.Enqueue("Bob", -2);

            Console.WriteLine("Treatment Order:");

            while (pq.Count > 0)
            {
                string patient = pq.Dequeue();
                Console.WriteLine(patient);
            }
        }
    }
}