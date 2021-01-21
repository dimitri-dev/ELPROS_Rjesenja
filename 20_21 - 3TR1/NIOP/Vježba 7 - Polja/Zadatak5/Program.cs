using System;
using System.Linq;

namespace Zadatak5
{
    class NIOP
    {
        static void Main(string[] args)
        {
            int[] arr = Enumerable.Range(1, 10).ToArray();
            int pairCount = arr.Count(c => c % 2 == 0);
            Console.WriteLine($"Polje ima {pairCount} parnih vrijednosti i {arr.Length - pairCount} neparnih.");
        }
    }
}
