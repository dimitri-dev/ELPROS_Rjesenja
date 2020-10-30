using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vježba_4___Enkapsulacija
{
    class Program
    {
        static void Main(string[] args)
        {
            #region initialization
            Ucenik[] ucenici = new Ucenik[5];

            for (int i = 0; i < ucenici.Length; ++i)
            {
                Data_Osobe data = new Data_Osobe();
                ucenici[i] = new Ucenik(data.first_name[i], data.last_name[i], data.razred, data.OIB);
            }

            Data_Osobe data_n = new Data_Osobe();
            Nastavnik nastavnik = new Nastavnik(data_n.first_name[6], data_n.last_name[6]);
            #endregion

            #region task

            // Upisivanje ocjena preko int-ova
            nastavnik.AddGrade(2, ucenici[1]);
            nastavnik.AddGrade(5, ucenici[1]);

            // Upisivanje vise ocjena od jednom
            nastavnik.AddGrade(new int[] { 5, 5 }, ucenici[2]);
            nastavnik.AddGrade(new int[] { 5, 4 }, ucenici[3]);
            nastavnik.AddGrade(new int[] { 1, 1 }, ucenici[4]);
            nastavnik.AddGrade(new int[] { 3, 4 }, ucenici[0]);

            // Ispisati ocjene prvog ucenika
            nastavnik.OutputGrades(ucenici[0]);

            // Ispisati prosjek svakog ucenika
            foreach (Ucenik ucenik in ucenici)
                nastavnik.OutputAverage(ucenik);
            Console.WriteLine("\n");

            // Ispisati ucenika sa najvecim prosjekom
            // v2 - Ipak uspio rjesiti LINQ-om.
            var prosjeci = ucenici.Select(o => o.prosjek).ToList();
            Console.WriteLine($"Ucenik sa najvecim prosjekom je {ucenici[prosjeci.IndexOf(prosjeci.Max())].ime} {ucenici[prosjeci.IndexOf(prosjeci.Max())].prezime}," +
                              $" a njegov prosjek iznosi {prosjeci.Max()}\n");

            #endregion

            #region problem_task
            // Zakljucivanje ocjena
            foreach (Ucenik ucenik in ucenici)
                nastavnik.LockGrade(ucenik);

            // Console cleaning
            Console.WriteLine("\nPress to continue on to the second part.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Finalni ispis: \n");

            foreach (Ucenik ucenik in ucenici)
            {
                ucenik.OutputGrades();
                ucenik.OutputAverage();
                ucenik.OutputLockedGrade();
            }
            #endregion
            Console.ReadLine();
        }
    }
}
