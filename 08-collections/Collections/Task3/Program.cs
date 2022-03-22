using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = LoadFromFile("Topic.txt");

            Dictionary<string, int> frequencyDictionary = CountWords(inputText);
        }

        static string LoadFromFile(string path)
        {
            string text;

            using (StreamReader sr = new StreamReader(path))
            {
                text = sr.ReadToEnd();
            }

            return text;
        }

        static Dictionary<string, int> CountWords(string text)
        {
            Dictionary<string, int> wordsFrequency = new Dictionary<string, int>();

            string pattern = @"\b\w+\b";

            foreach (var item in Regex.Matches(text, pattern))
            {
                if (!wordsFrequency.ContainsKey(item.ToString().ToLower()))
                {
                    wordsFrequency.Add(item.ToString().ToLower(), 1);
                }
                else
                {
                    wordsFrequency[item.ToString().ToLower()]++;
                }
            }

            return wordsFrequency;
        }
    }
}
