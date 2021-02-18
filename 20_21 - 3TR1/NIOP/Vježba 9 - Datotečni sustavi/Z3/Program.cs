using System;
using System.IO;

namespace NIOP
{
    class Z3
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("Kvadrati.txt"))
            {
                for (int i = 0; i < 5; ++i)
                {
                    Console.Write($"Unesite {i + 1}. broj: ");
                    sw.WriteLine(Math.Pow(Convert.ToInt32(Console.ReadLine()), 2));
                }
            }
        }
    }
}
