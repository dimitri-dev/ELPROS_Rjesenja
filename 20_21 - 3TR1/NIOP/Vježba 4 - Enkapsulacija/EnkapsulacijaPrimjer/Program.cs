using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnkapsulacijaPrimjer
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik u1 = new Ucenik("Ivan", "Ivanić");
            
            u1.PovecajDzeparac(20);
            u1.PovecajDzeparac(40);
            u1.PovecajDzeparac(10);
            u1.SmanjiDzeparac(15);

            u1.IspisiDzeparac();

            Console.ReadKey();
        }
    }
}
