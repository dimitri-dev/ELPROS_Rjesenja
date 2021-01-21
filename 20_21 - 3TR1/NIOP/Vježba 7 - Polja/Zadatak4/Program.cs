using System;
using System.Linq;

namespace Zadatak4
{
    class NIOP
    {
        static void Main(string[] args)
        {
            int[] arr_uno = Enumerable.Range(1, 10).ToArray();
            int[] arr_dos = Enumerable.Range(26, 10).ToArray();

            int[] arr_finalo = arr_uno.Select((x, idx) => x + arr_dos[idx]).ToArray();

            // Nije pisalo da treba ispis no
            foreach (int elem in arr_finalo)
                Console.WriteLine($"{elem}");
        }
    }
}
