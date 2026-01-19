namespace Map
{
    public class FrequencyCounter
    {
        public static void Counter()
        {
            string text = "winter is coming";

            string[] words = text.Split(' ');

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word]++;
                else
                    wordCount[word] = 1;
            }
            foreach (var v in wordCount)
            {
                Console.WriteLine(v.Key + " : " + v.Value);
            }
        }
    }
}