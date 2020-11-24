using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KeyValuePair<double, double>> kruznicaPovrsina = new List<KeyValuePair<double, double>>();

            for (int i = 0; i < 5; ++i)
            {
                Console.Write("Unesite duljine polumjera (radijusa) kruga u cm: ");
                double r = Convert.ToInt32(Console.ReadLine());

                kruznicaPovrsina.Add(new KeyValuePair<double, double>(r, Circle_Surface(r)));

                /* Brojevi su zaokruženi na 4 decimalna mjesta sa {var:0.0000} formatiranjem
                 * Ukoliko zelimo kompletan (izvorni) iznos, mozemo maknuti ":0.0000" i ostaviti samo
                 * varijablu tj. npr umjesto {Circle_Surface(r):0.0000} ostavimo {Circle_Surface(r)}.
                 */
                Console.WriteLine($"Površina Vašeg kruga iznosi {kruznicaPovrsina[i].Value:0.0000} cm kvadratnih.\n");
            }

            var s = (from entry in kruznicaPovrsina select entry.Value).ToList();

            Console.WriteLine($"\nKružnica sa najmanjom površinom je: \n" +
                              $"r = {kruznicaPovrsina[s.IndexOf(s.Min())].Key:0.0000} cm\n" +
                              $"P = {s.Min():0.0000} cm kvadratnih.");

            Console.WriteLine($"\nKružnica sa najvećom površinom je: \n" +
                              $"r = {kruznicaPovrsina[s.IndexOf(s.Max())].Key:0.0000} cm\n" +
                              $"P = {s.Max():0.0000} cm kvadratnih.");
        }

        static double Circle_Surface(double x)
        {
            return (Math.Pow(x, 2) * Math.PI);
        }
    }
}
