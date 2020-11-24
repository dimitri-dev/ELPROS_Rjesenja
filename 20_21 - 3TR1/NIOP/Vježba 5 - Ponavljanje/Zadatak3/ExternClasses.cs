using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    public class MrezniOperater : Osoba
    {
        public MrezniOperater(string a, string b, string c, double m)
        {
            Ime = a;
            Prezime = b;
            OIB = c;
            Placa = m;
        }
    }

    public class Programer : Osoba
    {
        public Programer(string a, string b, string c, double m)
        {
            Ime = a;
            Prezime = b;
            OIB = c;
            Placa = m;
        }
    }
}
