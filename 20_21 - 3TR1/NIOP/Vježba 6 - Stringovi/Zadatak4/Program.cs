using System;

namespace Zadatak4
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Danas radimo sa klasom String";

            x = x.Insert(x.Length, " ili mozda sutra");
            Console.WriteLine(x);
        }
    }
}
