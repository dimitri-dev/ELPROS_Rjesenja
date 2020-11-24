using System;

namespace Zadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            MrezniOperater osobaMO = new MrezniOperater("Igor", "Uglik", "49911022192", 13410);
            Programer osobaP = new Programer("Igorina", "Uglik", "49911012192", 17093);

            Console.WriteLine("Mrezni operater: ");
            osobaMO.IspisiDetalje();

            Console.WriteLine("Programer: ");
            osobaP.IspisiDetalje();

            if (osobaP.Placa > osobaMO.Placa)
                Console.WriteLine("Programer ima vecu placu.");
            else if (osobaP.Placa == osobaMO.Placa)
                Console.WriteLine("Programer i Mrezni Operater imaju istu placu.");
            else
                Console.WriteLine("Mrezni operater ima vecu placu.");
        }
    }
}
