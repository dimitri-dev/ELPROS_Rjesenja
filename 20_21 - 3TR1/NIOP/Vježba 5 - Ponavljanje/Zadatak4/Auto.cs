using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    class Auto
    {
        private bool ignited = false;
        private int brojKilometara = 0;

        public void Upali()
        {
            if (!ignited)
            {
                ignited = true;
                Console.WriteLine("Auto upaljen.");
            }
            else
                Console.WriteLine("Auto je vec upaljen.");

        }

        public void Ugasi()
        {
            if (ignited)
            {
                ignited = false;
                Console.WriteLine("Auto ugasen.");
            }
            else
                Console.WriteLine("Auto je vec ugasen.");

        }

        public void Vozi(int brojKilometara)
        {
            if (brojKilometara >= 0)
            {
                if (ignited)
                {
                    Console.WriteLine($"Vozi {brojKilometara} km.");
                    this.brojKilometara += brojKilometara;
                }
                else
                    Console.WriteLine("Auto je ugasen, ne moze voziti. Prvo upali auto.");
            }
            else
                Console.WriteLine("Unesen je negativan broj kilometara.");
        }

        public void Stani()
        {
            Console.WriteLine("Auto stao.");
        }
        
        public void IspisiKilometrazu()
        {
            Console.WriteLine($"Auto je prešao {this.brojKilometara} km.");
        }
    }
}
