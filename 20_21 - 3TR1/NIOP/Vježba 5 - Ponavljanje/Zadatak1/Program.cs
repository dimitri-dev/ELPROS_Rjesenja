using System;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "Ivan", "Mihael", "Dzorde", "Herman", "Neuman" };

            forLoop(s);
            foreachLoop(s);
            whileLoop(s);
            doWhileLoop(s);
        }

        static void forLoop(string[] sA)
        {
            for (int i = 0; i < sA.Length; i++)
            {
                Console.WriteLine($"Ime: {sA[i]}\n" +
                                  $"Duljina imena: {sA[i].Length}");
            }
            Console.WriteLine();
        }

        static void foreachLoop(string[] sA)
        {
            foreach (var s in sA)
            { 
                Console.WriteLine($"Ime: {s}\n" +
                                  $"Duljina imena: {s.Length}");
            }
            Console.WriteLine();
        }

        static void whileLoop(string[] sA)
        {
            int i = 0;
            while (i < sA.Length)
            { 
                Console.WriteLine($"Ime: {sA[i]}\n" +
                                  $"Duljina imena: {sA[i].Length}");
                ++i;
            }
            Console.WriteLine();

        }

        static void doWhileLoop(string[] sA)
        {
            int i = 0;
            do
            {
                Console.WriteLine($"Ime: {sA[i]}\n" +
                                  $"Duljina imena: {sA[i].Length}");
                ++i;
            } while (i < sA.Length);
            Console.WriteLine();
        }
    }
}
