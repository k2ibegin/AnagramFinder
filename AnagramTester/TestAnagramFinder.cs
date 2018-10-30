using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using FindAnagrams;

namespace AnagramTester
{
    [TestFixture]
    public class TestAnagramFinder
    {
        private AnagramFinder _AnagramFinder;
        private string path = @"D:\InputFile.txt";
        private List<string> InputData;

        [SetUp]
        public void Init()
        {
            _AnagramFinder = new AnagramFinder();
            InputData = FileReader.ReadAllStrings(path);
        }


        [Test]
        public void FindAllAnagrams_ReturnsAllPossibleAnagramsInDictionary()
        {
            var anagramMap = _AnagramFinder.FindAllAnagrams(InputData);
            Assert.True(anagramMap.Count > 0);
        }

        [Test]
        public void FindAnagramSetWithMostWords_ReturnsLongestAnagramSet()
        {
            var anagramSet = _AnagramFinder.FindAnagramSetWithMostWords(InputData);
            Assert.True(anagramSet.Length > 0);
        }

        [Test]
        public void FindLongestAnagramWord_ReturnsLongestAnagram()
        {
            var anagram = _AnagramFinder.FindLongestAnagramWords(InputData);
            Assert.True(anagram.Length > 0);
        }
    }
}
