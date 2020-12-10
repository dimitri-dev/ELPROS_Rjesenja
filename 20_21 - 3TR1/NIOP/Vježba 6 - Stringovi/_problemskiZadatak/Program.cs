using System;
using System.Collections.Generic;
using System.Linq;

namespace problemskiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            string loremIpsum = "Lorem ipsum234 dolor sit 23434amet, 41ons1234234r adipis99cing e4121341234lit. Nu34123lla s4124agittis l51orem 3241quam. In h88ac hab7itass123e platea dictums6669t. Ut i55d sollicitudin25l5rem, vel co2341523mmodo ve21lit. N44unc. ";
            
            var counterList = from entry in loremIpsum where char.IsDigit(entry) == true select Convert.ToInt32(entry-48);
            
            Dictionary<int, int> frequencySort = counterList.GroupBy(x => x).OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Count());

            string cleanLoremIpsum = new string(loremIpsum.Where(x => char.IsDigit(x) == false).ToArray());

            Console.WriteLine($"String prije ciscenja brojeva: ");
            Console.WriteLine(loremIpsum + "\n");

            Console.WriteLine($"Cisti string izgleda ovako: ");
            Console.WriteLine(cleanLoremIpsum + "\n");

            Console.WriteLine($"Sveukupno je bilo {frequencySort.Values.Sum()} brojeva.\n");

            foreach (var k in frequencySort)
                Console.WriteLine($"Broj {k.Key} ponavljao se {k.Value} puta.");
        }
    }
}
