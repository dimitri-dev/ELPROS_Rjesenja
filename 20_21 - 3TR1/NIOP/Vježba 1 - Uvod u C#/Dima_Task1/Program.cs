using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dima_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pravokutnik = (0.01, 0.01);
            Console.WriteLine("Unesite duljine dvaju stranica u centimetrima: ");
            
            Console.Write("Stranica a (cm): ");
            pravokutnik.Item1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Stranica b (cm): ");
            pravokutnik.Item2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nOpseg Vašeg pravokutnika iznosi {Square_Perimeter(pravokutnik)} cm," +
                                $" a površina iznosi {Square_Surface(pravokutnik)} cm kvadratnih.");
            Console.ReadKey();
        }

        static double Square_Perimeter((double, double) x)
        {
            return (2 * x.Item1 + 2 * x.Item2);
        }

        static double Square_Surface((double, double) x)
        {
            return (x.Item1 * x.Item2);
        }
    }
}
