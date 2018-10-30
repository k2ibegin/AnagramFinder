using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAnagrams
{
    public static class FileReader
    {
        public static List<string> ReadAllStrings(string path)
        {
            try
            {
                var listOfFiles = File.ReadLines(path).ToList();
                return listOfFiles;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error while reading file at path : " + path);
                Console.WriteLine(e.Message);
                return new List<string>();
            }
            
        }
    }
}
