using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba_3
{
    class Nastavnik : Osoba
    {
        public bool Razrednik { get; set; }
        public Nastavnik(string ime, string prezime, DateTime datumRodjenja, bool razrednik, long oib)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            Razrednik = razrednik;
            OIB = oib;
        }
        public override void WriteData()
        {
            base.WriteData();
            Console.WriteLine($"Razrednik: " + (Razrednik ? "Da\n" : "Ne\n"));
        }
    }

}
