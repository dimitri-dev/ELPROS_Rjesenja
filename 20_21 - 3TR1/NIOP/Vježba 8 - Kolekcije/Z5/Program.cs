using System;
using System.Collections.Generic;
using System.Linq;

namespace NIOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ls1 = Enumerable.Range(1, 10).ToList();
            List<int> ls2 = Enumerable.Range(59, 10).Reverse().ToList();

            List<int> ls3 = ls1.Select((x, idx) => x + ls2[idx]).ToList();

            foreach (int elem in ls3)
                Console.WriteLine($"{elem}");
        }
    }
}
