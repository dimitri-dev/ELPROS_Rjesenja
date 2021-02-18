using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NIOP
{
    class PZ
    {
        static void Main(string[] args)
        {
            string loremIpsum = "";
            using (StreamReader sr = new StreamReader("LoremIpsum.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null) loremIpsum += line;        
            }

            Dictionary<char, int> frequencySort = loremIpsum.GroupBy(x => x).OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Count());

            // int spaceCount = (loremIpsum.Where(x => x == ' ').ToArray().Count());
            int spaceCount = frequencySort[' '];

            Console.WriteLine($"Razmak se pojavio {spaceCount}");
            
            // Dictionary cleanup
            frequencySort.Remove(','); frequencySort.Remove(' '); frequencySort.Remove('.');
            
            foreach (var k in frequencySort)
                Console.WriteLine($"Slovo {k.Key} ponavljalo se {k.Value} puta.");
        }
    }
}
