/*Invert a Map
Invert a Dictionary<K, V> to produce a Dictionary<V, List<K>>.
Example:
Input: { A=1, B=2, C=1 }
Output: { 1=[A, C], 2=[B] }*/



namespace Map
{
    public class InvertMap
    {
        public static void Invert()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };

            Dictionary<int, List<string>> inverted = new Dictionary<int, List<string>>();

            foreach (var v in dict)
            {
                int value = v.Value;
                string key = v.Key;

                if (!inverted.ContainsKey(value))
                {
                    inverted[value] = new List<string>();
                }

                inverted[value].Add(key);
            }


            foreach (var item in inverted)
            {
                Console.Write(item.Key + " = [ ");
                foreach (var k in item.Value)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine("]");
            }
        }
    }
}