using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Osoba[] osobe = new Osoba[10];

            for (int i = 0; i < osobe.Length; ++i)
            {
                Data_Osobe data = new Data_Osobe();
                if (i < 5)
                    osobe[i] = new Ucenik(data.first_name[i], data.last_name[i], data.dateTime_ucenik, data.razred, data.OIB);
                else
                    osobe[i] = new Nastavnik(data.first_name[i], data.last_name[i], data.dateTime_nastavnik, data.razrednik, data.OIB);

                osobe[i].WriteData();
            }

            Console.ReadLine();
        }
    }
}
