using FindAnagrams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAnagramsMain
{
    class Program
    {
        static void Main(string[] args)
        {
            AnagramFinder anagramFinder = new AnagramFinder();

            Console.WriteLine("Please enter the input file path containing possible anagrams ");
            string path = Console.ReadLine();
            var inputList = FileReader.ReadAllStrings(path);
            if (inputList.Count == 0)
                return;

            Console.WriteLine("All possible anagrams in input file");
            Console.WriteLine();
            anagramFinder.PrintAllAnagrams(inputList);
            anagramFinder.Clear();
            Console.WriteLine();
            Console.WriteLine("Longest anagram set in the input file");
            Console.WriteLine();
            Console.WriteLine(anagramFinder.FindAnagramSetWithMostWords(inputList));
            anagramFinder.Clear();
            Console.WriteLine();
            Console.WriteLine("Longest words that are anagrams in input file");
            Console.WriteLine();
            Console.WriteLine(anagramFinder.FindLongestAnagramWords(inputList));
            anagramFinder.Clear();
        }
    }
}
