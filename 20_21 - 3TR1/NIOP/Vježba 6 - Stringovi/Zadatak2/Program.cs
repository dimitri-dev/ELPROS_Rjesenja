using System;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            string x1 = "Danas ", x2 = "radimo ", x3 = "sa ", x4 = "klasom ", x5 = "String ";

            string x = String.Concat(x1, x2, x3, x4, x5);
            Console.WriteLine(x);
        }
    }
}
