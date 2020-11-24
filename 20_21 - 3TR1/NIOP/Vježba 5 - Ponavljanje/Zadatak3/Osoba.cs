using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    public class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string OIB { get; set; }
        public double Placa { get; set; }

        public void IspisiDetalje()
        {
            Console.WriteLine($"Ime: {Ime}\n" +
                              $"Prezime: {Prezime}\n" +
                              $"OIB: {OIB}\n");
        }
    }
}
