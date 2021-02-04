using System;
using System.Collections.Generic;
using System.Linq;

namespace NIOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ls = Enumerable.Range('A', 10).Select(c => Convert.ToString((char)c)).ToList();
            ls.Insert(0, "prvi element");
            foreach (string n in ls)
                Console.WriteLine(n);

            ls.Sort();
        }
    }
}
