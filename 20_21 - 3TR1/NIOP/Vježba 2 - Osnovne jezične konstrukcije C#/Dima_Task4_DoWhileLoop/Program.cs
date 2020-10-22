using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dima_Task4_DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do-While loop counter
            int i = 0;

            // Vrijednosti za Random.Next funkciju
            int min = 1, max = 100;

            Console.Write("Za koliko trokuta zelite izracunati povrsinu: ");
            int nTriangles = Convert.ToInt32(Console.ReadLine());

            // a i b - int; c - double (hipotenuza); P - double (povrsina)
            var biggestTriangle =
                (a: 0,
                 b: 0,
                 c: 0.00,
                 P: 0.00);

            Random rnd = new Random();

            do
            {
                var randomTriangle =
                    (a: rnd.Next(min, max),
                     b: rnd.Next(min, max),
                     c: 0.00,
                     P: 0.00);

                randomTriangle.c = Math.Sqrt(Math.Pow(randomTriangle.a, 2) + Math.Pow(randomTriangle.b, 2));
                randomTriangle.P = randomTriangle.a * randomTriangle.b / 2;

                if (randomTriangle.P > biggestTriangle.P)
                    biggestTriangle = randomTriangle;

                Console.WriteLine($"Trokut {i + 1}:\n" +
                                  $"a = {randomTriangle.a} cm\n" +
                                  $"b = {randomTriangle.b} cm\n" +
                                  $"c = {randomTriangle.c:0.####} cm\n" +
                                  $"P = {randomTriangle.P:0.####} cm\n");

                ++i;
            } while (i < nTriangles);

            Console.WriteLine($"Trokut s NAJVECOM povrsinom:\n" +
                                  $"a = {biggestTriangle.a} cm\n" +
                                  $"b = {biggestTriangle.b} cm\n" +
                                  $"c = {biggestTriangle.c:0.####} cm\n" +
                                  $"P = {biggestTriangle.P:0.####} cm\n");

            Console.ReadLine();
        }
    }
}
