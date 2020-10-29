using System;

namespace EnkapsulacijaPrimjer
{
    public class Ucenik
    {
        public string Ime { get; set; }

        public string Prezime { get; set; }

        //TODO enkaspulacija, skrivanje varijable. Moguć je pristup samo unutar klase Učenik.
        private int Dzeparac { get; set; }
        
        //TODO konstruktor
        public Ucenik() {}

        //TODO konstruktor sa parametrima
        public Ucenik(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        public void PovecajDzeparac(int iznos)
        {
            Dzeparac += iznos;
            //Dzeparac = Dzeparac + iznos;
        }

        public void SmanjiDzeparac(int iznos)
        {
            Dzeparac -= iznos;
            //Dzeparac = Dzeparac - iznos;
        }

        public void IspisiDzeparac()
        {
            Console.WriteLine($"Učenik {Ime} {Prezime} ima dzeparac: {Dzeparac} kn.");
        }

    }
}