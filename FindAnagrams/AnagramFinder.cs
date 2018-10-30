using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAnagrams
{
    public class AnagramFinder
    {
        private Dictionary<string, string> _AnagramMap = new Dictionary<string, string>();

        public Dictionary<string,string> FindAllAnagrams(List<string> inputData)
        {
            inputData = inputData.ConvertAll(a => a.ToLower());
            foreach (var name in inputData)
            {
                var sortedName = SortString(name);
                if(_AnagramMap.ContainsKey(sortedName))
                {
                    var value = _AnagramMap[sortedName];
                    value += " " + name;
                    _AnagramMap[sortedName] = value;
                }else
                {
                    _AnagramMap[sortedName] = name;
                }
            }

            return RemoveNonAnagrams(_AnagramMap);
        }

        public void PrintAllAnagrams(List<string> inputData)
        {
            var anagrams = FindAllAnagrams(inputData);
            foreach(var kvp in anagrams)
            {
                Console.WriteLine(kvp.Value);
            }
        }

        public void Clear()
        {
            _AnagramMap.Clear();
        }

        private Dictionary<string, string> RemoveNonAnagrams(Dictionary<string, string> anagramMap)
        {
            var dictionary = anagramMap.Where(s => s.Value.Split(' ').Count() > 1).ToDictionary(x => x.Key, x => x.Value);
            return dictionary;
        }

        public string FindAnagramSetWithMostWords(List<string> inputData)
        {
            var anagramMap = FindAllAnagrams(inputData);
            string longestAnagramSet = "";
            int longestAnagramSetCount = 0;

            
            foreach (var kvp in anagramMap)
            {
                string value = kvp.Value;
                var arrAnagrams = value.Split(' ');
                if(arrAnagrams.Length > longestAnagramSetCount)
                {
                    longestAnagramSet = value;
                    longestAnagramSetCount = arrAnagrams.Length;
                }
            }

            return longestAnagramSet;
        }

        public string FindLongestAnagramWords(List<string> inputData)
        {
            var anagramMap = FindAllAnagrams(inputData);
            var result = anagramMap.OrderByDescending(s => s.Key.Length);

            string longestAnagramWords = "";
            int previousKeyLength = result.Select(s => s.Key.Length).FirstOrDefault();

            foreach (var kvp in result)
            {
                if (previousKeyLength > kvp.Key.Length)
                    break;

                longestAnagramWords += " " + kvp.Value;
            }

            return longestAnagramWords;
        }

        private static string SortString(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }
    }
}
