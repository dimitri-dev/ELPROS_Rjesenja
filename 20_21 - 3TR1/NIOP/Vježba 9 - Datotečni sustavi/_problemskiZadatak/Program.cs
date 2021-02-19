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

            // ALT: int spaceCount = (loremIpsum.Where(x => x == ' ').ToArray().Count());
            int spaceCount = frequencySort[' '];

            // Dictionary cleanup of random non-letter chars.
            // Can be removed, depending on what letter-count algorithm you want the Grouping and Ordering to handle.
            // ALT (for totalCount): int totalCount = loremIpsum.Count(); -> for all chars (not just letters).
            frequencySort.Remove(','); frequencySort.Remove(' '); frequencySort.Remove('.');
            int totalCount = frequencySort.Sum(x => x.Value);

            Console.WriteLine($"Razmak se pojavio {spaceCount}, te je ukupno bilo {totalCount} slova.");            
            
            foreach (var k in frequencySort)
                Console.WriteLine($"Slovo {k.Key} ponavljalo se {k.Value} puta.");
        }
    }
}
