using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba_3
{
    class Ucenik : Osoba
    {
        public int Razred { get; set; }
        public Ucenik(string ime, string prezime, DateTime datumRodjenja, int razred, long oib)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            Razred = razred;
            OIB = oib;
        }
        public override void WriteData()
        {
            base.WriteData();
            Console.WriteLine($"Razred: {Razred}\n");
        }
    }

}
