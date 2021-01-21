using System;
using System.Linq;

namespace Zadatak1
{
    class NIOP
    {
        static void Main(string[] args)
        {
            int[] arr = Enumerable.Range(1, 100).ToArray();

            Console.WriteLine($"Suma elemenata iznosi: {arr.Sum()}.");
            Console.WriteLine($"Povecavamo svaki element u polju za 5.");

            arr = arr.Select(c => c += 5).ToArray();
            Console.WriteLine($"Suma elemenata sada iznosi: {arr.Sum()}.");
        }
    }
}
