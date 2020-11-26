using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    public class Komponenta
    {
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public string Proizvodac { get; set; }

        public virtual void IspisiDetalje()
        {
            Console.WriteLine($"Proizvodac: {Proizvodac}");
            Console.WriteLine($"Naziv: {Naziv}");
            Console.WriteLine($"Cijena: {Cijena} evra");
        }
    }

    public class GPU : Komponenta
    {
        public string Memorija { get; set; }

        public GPU(string name, double price, string vendor, string mem)
        {
            Naziv = name;
            Cijena = price;
            Proizvodac = vendor;
            Memorija = mem;
        }

        public override void IspisiDetalje()
        {
            Console.WriteLine("Graficka kartica:");
            base.IspisiDetalje();
            Console.WriteLine($"Memorija: {Memorija}");
        }
    }

    public class SSD : Komponenta
    {
        public string Kapacitet { get; set; }

        public SSD(string name, double price, string vendor, string mem)
        {
            Naziv = name;
            Cijena = price;
            Proizvodac = vendor;
            Kapacitet = mem;
        }

        public override void IspisiDetalje()
        {
            Console.WriteLine("\n\nSSD:");
            base.IspisiDetalje();
            Console.WriteLine($"Kapacitet: {Kapacitet}");
        }
    }

    public class CPU : Komponenta
    {
        public string Frekvencija { get; set; }
        public string Cache { get; set; }
        public int BrojJezgri { get; set; }

        public CPU(string name, double price, string vendor,
                   string freq, string cache, int coreCount)
        {
            Naziv = name;
            Cijena = price;
            Proizvodac = vendor;
            Frekvencija = freq;
            Cache = cache;
            BrojJezgri = coreCount;
        }

        public override void IspisiDetalje()
        {
            Console.WriteLine("\n\nProcesor:");
            base.IspisiDetalje();
            Console.WriteLine($"Frekvencija: {Frekvencija}");
            Console.WriteLine($"Cache: {Cache}");
            Console.WriteLine($"Broj Jezgri: {BrojJezgri}");
        }
    }
}
