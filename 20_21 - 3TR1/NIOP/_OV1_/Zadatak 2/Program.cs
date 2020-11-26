using System;

namespace Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            GPU grafa = new GPU("RTX 2070", 400, "Ja", "8GB GDDR6X");
            SSD disk = new SSD("P1", 100, "Crucial", "1TB");
            CPU procesor = new CPU("i30", 7800, "inTel",
                                   "4.9THz", "256GB L3", 30);

            Console.WriteLine($"Graficka kartica: \n" +
                              $"Proizvođač: {grafa.Proizvodac}\n" +
                              $"Naziv: {grafa.Naziv}\n" +
                              $"Memorija: {grafa.Memorija}\n" +
                              $"Cijena: {grafa.Cijena} evra");

            Console.WriteLine($"\n\nSSD: \n" +
                              $"Proizvođač: {disk.Proizvodac}\n" +
                              $"Naziv: {disk.Naziv}\n" +
                              $"Kapacitet: {disk.Kapacitet}\n" +
                              $"Cijena: {disk.Cijena} evra");

            Console.WriteLine($"\n\nProcesor: \n" +
                              $"Proizvođač: {procesor.Proizvodac}\n" +
                              $"Naziv: {procesor.Naziv}\n" +
                              $"Frekvencija: {procesor.Frekvencija}\n" +
                              $"Cache: {procesor.Cache}\n" +
                              $"Broj jezgri: {procesor.BrojJezgri}\n" +
                              $"Cijena: {procesor.Cijena} evra");

            Console.WriteLine("\n\nClear window. Press Enter.");
            Console.ReadLine();
            Console.Clear();

            grafa.IspisiDetalje();
            disk.IspisiDetalje();
            procesor.IspisiDetalje();
        }
    }
}
