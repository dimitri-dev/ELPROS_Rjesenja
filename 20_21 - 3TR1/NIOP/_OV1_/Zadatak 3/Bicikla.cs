using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_3
{
    public class Bicikla
    {
        private int PrijedeniKilometri { get; set; }
        private int StanjeKocnica { get; set; }

        public Bicikla()
        {
            PrijedeniKilometri = 0;
            StanjeKocnica = 100;
        }

        public void Vozi(int brojKm)
        {
            Console.WriteLine("Vozja aktivna.");

            PrijedeniKilometri += brojKm;
        }

        public void Stani()
        {
            Console.WriteLine("Voznja prekinuta.");
            --StanjeKocnica;
        }

        public void IspisiKilometrazu()
        {
            Console.WriteLine($"\nPresli ste: {PrijedeniKilometri} km.");
        }

        public void IspisiStanjeKocnica()
        {
            Console.WriteLine($"Stanje kocnica: {StanjeKocnica} % ");
        }
    }
}
