using System;
using System.Collections.Generic;
using System.Linq;

namespace NIOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ucenik> ls = new List<Ucenik> { new Ucenik("Ivan", "Ivanic", "49907035111", 21),
                                                 new Ucenik("Pero", "Peric", "47922055192", 69),
                                                 new Ucenik("Jakov", "Paralomovic", "44199100221", 10),
                                                 new Ucenik("Neven", "Maric", "49907035169", 15),
                                                 new Ucenik("Borna", "Laksovic", "14429100269", 116)};

            List<Ucenik> queryRes = (from entry in ls where entry.Dzeparac > 20 select entry).ToList();

            foreach (Ucenik uc in queryRes)
                Console.WriteLine($"{uc}");

        }
    }

    class Ucenik
    {
        public string Ime;
        public string Prezime;
        public string OIB;
        public int Dzeparac;

        public Ucenik(string name, string lastName, string OIB, int money)
        {
            Ime = name;
            Prezime = lastName;
            this.OIB = OIB;
            Dzeparac = money;
        }

        public override string ToString()
        {
            return String.Format($"Ucenik: {Ime} {Prezime}\nOIB: {OIB}\nDzeparac: {Dzeparac}\n");
        }
    }
}
