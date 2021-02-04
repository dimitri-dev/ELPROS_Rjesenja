using System;
using System.Collections.Generic;
using System.Linq;

namespace NIOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            List<int> ls = Enumerable.Range(1, 1000).Select(i => rng.Next(1, 15000)).ToList();

            foreach (int elem in ls)
                if (elem % 2 == 0) Console.WriteLine($"Paran broj: {elem}");
                else Console.WriteLine($"Neparan broj: {elem}");

            List<int> qryLs = (from entry in ls where entry % 2 == 0 select entry).ToList();
            
            Console.WriteLine("\n\nBolji output nakon pritiska tipke Enter...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Parni elementi: ");
            foreach (int elem in qryLs)
                Console.Write($"{elem} ");

            List<int> rem = ls.Except(qryLs).ToList();
            Console.WriteLine("\n\nNeparni elementi: ");
            foreach (int elem in rem)
                Console.Write($"{elem} ");
        }
    }
}
