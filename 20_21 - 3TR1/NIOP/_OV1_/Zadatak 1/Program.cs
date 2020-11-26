using System;
using System.Linq;

namespace _OV1_
{
    class Program
    {
        static void Main(string[] args)
        {
            var lorem = new string[] { "Lorem", "ipsum", "dolor", "sit", "amet", ",", "consectetur", "adipiscing", "elit", ".", "Fusce", "quis", "." };

            Console.WriteLine($"Duljina lorem varijable {lorem.Length}");
            Console.WriteLine($"\nBroj ponavljanja znakova: ");

            // Moj omiljeni klasik solušn - BONUS
            var freq = (from entry in lorem where entry.Contains(".") || entry.Contains(",") select entry).ToList();

            Console.WriteLine($"\nMy solution:");
            Console.WriteLine($", : {freq.Count(f => f == ",")}");
            Console.WriteLine($". : {freq.Count(f => f == ".")}");

            // For-Loop
            int dotCount = 0;
            int commaCount = 0;

            for (int i = 0; i < lorem.Length; i++)
            {
                // IFovi su absolutno nepotrebni za ovakav nacin (kao sto je vidljivo u while petlji)
                if (lorem[i].Contains('.')) dotCount += lorem[i].Count(x => x == '.');
                if (lorem[i].Contains(',')) commaCount += lorem[i].Count(x => x == ',');
            }

            Console.WriteLine($"\nFor loop:");
            Console.WriteLine($", : {commaCount}");
            Console.WriteLine($". : {dotCount}");

            // While-Loop
            dotCount = 0;
            commaCount = 0;
            int iter = 0;

            while (iter < lorem.Length)
            { 
                dotCount += lorem[iter].Count(x => x == '.');
                commaCount += lorem[iter].Count(x => x == ',');
                ++iter;
            }

            Console.WriteLine($"\nWhile loop:");
            Console.WriteLine($", : {commaCount}");
            Console.WriteLine($". : {dotCount}");

            // Do-While-Loop
            dotCount = 0;
            commaCount = 0;
            iter = 0;

            do
            {
                dotCount += lorem[iter].Count(x => x == '.');
                commaCount += lorem[iter].Count(x => x == ',');
                ++iter;
            } while (iter < lorem.Length);

            Console.WriteLine($"\nDo-while loop:");
            Console.WriteLine($", : {commaCount}");
            Console.WriteLine($". : {dotCount}");

        }
    }
}
