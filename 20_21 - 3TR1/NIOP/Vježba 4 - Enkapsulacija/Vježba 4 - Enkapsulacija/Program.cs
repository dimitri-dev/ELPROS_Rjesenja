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
            Pair max = ArrayMaxProsjek(ucenici);
            Console.WriteLine($"Ucenik sa najvecim prosjekom je {ucenici[max.element_One].ime} {ucenici[max.element_One].prezime}," +
                              $" a njegov prosjek iznosi {max.element_Two}\n");

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

        public static Pair ArrayMaxProsjek(Ucenik[] arr)
        {
            int index = -1;
            float max = -1;
            
            // Message for professor:
            // Pokusao sam ovo nekako rjesiti sa LINQ-om, ali zapravo nisam imao blage veze... :/
            // Ideja je bila da se napravi nekakav linq sa foreach-om koji ce uzet svaki "Ucenik ucenik in ucenici"
            // Te access-ati njegov .prosjek atribut i append-ati ga u neku listu/array
            // Ako imate ideju kako bi se to radilo u ovom kodu, please let me know :)

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i].prosjek > max)
                {
                    max = arr[i].prosjek;
                    index = i;
                }
            }

            return new Pair(index, max);
        }
    }

    public class Pair
    {
        // int - index_ucenika, float - prosjek_ucenika
        public int element_One;
        public float element_Two;

        public Pair(int a, float v)
        {
            element_One = a;
            element_Two = v;
        }

        public Pair()
        {
            element_One = -1; // nevaljani index
            element_Two = -1; // nevaljani prosjek
        }
    }
}
