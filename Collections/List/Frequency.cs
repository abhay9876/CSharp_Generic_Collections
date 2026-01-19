/*Find Frequency of Elements
Given a list of strings, count the frequency of each element and return the
results in a Dictionary<string, int>.
Example:
Input: {"apple", "banana", "apple", "orange"}
Output: { "apple": 2, "banana": 1, "orange": 1 }*/



namespace List
{
    class Frequency
    {
        public static void Solution()

        {
            List<string> fruits = new List<string>() { "apple", "banana", "apple", "orange" };
            Dictionary<string, int> element = FindFrequency(fruits);
            // Print all Element with Frequency
            foreach (var item in element)
            {
                Console.WriteLine($"Fruit : {item.Key}   Count : {item.Value}");
            }
        }
        // Method to find frequency
        public static Dictionary<string, int> FindFrequency(List<string> list)
        {
            Dictionary<string, int> fre = new Dictionary<string, int>();

            foreach (var v in list)
            {
                if (fre.ContainsKey(v))
                {
                    fre[v]++;
                }
                else
                {
                    fre[v] = 1;
                }
            }
            return fre;
        }
    }
}