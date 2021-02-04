using System;
using System.Collections.Generic;
using System.Linq;

namespace NIOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ls = new List<int>();
            for (int i = 0; i < 10; ++i)
            {
                Console.Write($"Unesite {i + 1}. broj: ");
                ls.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine($"\n\nNajmanji broj je : {ls.Min()}");
            Console.WriteLine($"Najveci broj je : {ls.Max()}");
            Console.WriteLine($"Suma svih parnih brojeva je : {ls.Where(i => i % 2 == 0).Sum()}");
            Console.WriteLine($"Suma svih neparnih brojeva je : {ls.Where(i => i % 2 == 1).Sum()}");
            Console.WriteLine($"Suma svih brojeva je : {ls.Sum()}");
        }
    }
}
