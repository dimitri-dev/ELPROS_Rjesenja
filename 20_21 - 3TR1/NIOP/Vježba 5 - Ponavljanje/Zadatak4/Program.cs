using System;

namespace Zadatak4
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();

            auto.Upali();

            auto.Vozi(5);
            auto.Stani();

            auto.Vozi(15);
            auto.Stani();

            auto.Vozi(150);
            auto.Stani();

            auto.Ugasi();
            auto.IspisiKilometrazu();
        }
    }
}
