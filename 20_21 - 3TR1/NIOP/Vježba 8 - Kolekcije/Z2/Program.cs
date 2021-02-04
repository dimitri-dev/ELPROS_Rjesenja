using System;
using System.Collections.Generic;
using System.Linq;

namespace NIOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ucenik> ls = Enumerable.Range('A', 5).Select(c => new Ucenik(Convert.ToString((char)c))).ToList();
            ls.RemoveRange(0, 2);

            foreach (Ucenik student in ls)
                Console.WriteLine(student.ToString());
        }
    }

    class Ucenik
    {
        public string Ime;

        public Ucenik(string name)
        {
            Ime = name;
        }

        public override string ToString()
        {
            return "Ucenik: " + Ime;
        }
    }
}
