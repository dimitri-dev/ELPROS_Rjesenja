using System;
using System.Linq;

namespace Zadatak2
{
    class NIOP
    {
        static void Main(string[] args)
        {
            int[] arr = Enumerable.Range(1, 100).Reverse().ToArray();
            foreach (int elem in arr)
                Console.Write($"{elem} ");
        }
    }
}
