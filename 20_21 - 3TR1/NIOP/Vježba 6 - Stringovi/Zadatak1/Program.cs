using System;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Danas radimo sa klasom String";
            Console.WriteLine($"String x ima {x.Length} znakova.");

            Console.WriteLine($"\nString x velikim slovima: ");
            Console.WriteLine($"{x.ToUpper()}");

            Console.WriteLine($"\nString x malim slovima: ");
            Console.WriteLine($"{x.ToLower()}");

            x.Replace("Danas", "Sutra");
        }
    }
}
