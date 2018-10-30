using System;
using NUnit;
using NUnit.Framework;
using FindAnagrams;
using System.Collections.Generic;

namespace AnagramTester
{
    [TestFixture]
    public class TestFileReader
    {
        private static string _InputFilePath = @"D:\InputFile.txt";
        
        [Test]
        public void ReadAllStrings_ReadFile_ReturnsListOfStrings()
        {
            List<string> anagrams = FileReader.ReadAllStrings(_InputFilePath);
            Assert.True(anagrams.Count > 0);
        }
    }
}
