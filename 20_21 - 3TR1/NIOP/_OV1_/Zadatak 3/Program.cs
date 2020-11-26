using System;

namespace Zadatak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicikla bmx = new Bicikla();

            bmx.Vozi(100);
            bmx.Stani();
            bmx.Vozi(50);
            bmx.Stani();
            bmx.Vozi(69);
            bmx.Stani();

            bmx.IspisiKilometrazu();
            bmx.IspisiStanjeKocnica();
        }
    }
}
