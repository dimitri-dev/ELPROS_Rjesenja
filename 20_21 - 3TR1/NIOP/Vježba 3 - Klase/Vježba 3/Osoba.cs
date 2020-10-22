using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba_3
{
    class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public long OIB { get; set; }
        public virtual void WriteData()
        {
            Console.WriteLine(
                $"Ime: {Ime}\n" +
                $"Prezime: {Prezime}\n" +
                $"Datum rođenja: {DatumRodjenja}\n" +
                $"OIB: {OIB}");
        }
    }
}
