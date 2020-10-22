using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dima_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;

            Console.Write("Unesite duljine polumjera (radijusa) kruga u cm: ");
            r = Convert.ToInt32(Console.ReadLine());

            /* Brojevi su zaokruženi na 4 decimalna mjesta sa {var:0.0000} formatiranjem
             * Ukoliko zelimo kompletan (izvorni) iznos, mozemo maknuti ":0.0000" i ostaviti samo
             * varijablu tj. npr umjesto {Circle_Perimeter(r):0.0000} ostavimo {Circle_Perimeter(r)}.
             */
            Console.WriteLine($"\nOpseg Vašeg kruga iznosi {Circle_Perimeter(r):0.0000} cm," +
                                $" a površina iznosi {Circle_Surface(r):0.0000} cm kvadratnih.");
            Console.ReadKey();
        }

        static double Circle_Perimeter(int x)
        {
            return (2 * x * Math.PI);
        }

        static double Circle_Surface(int x)
        {
            return (Math.Pow(x, 2) * Math.PI);
        }
    }
}
