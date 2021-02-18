using System;
using System.IO;

namespace NIOP
{
    class Z1
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("nums.txt"))
            {
                for (int i = 1; i <= 100; ++i)
                    sw.WriteLine($"{i}");
            }
        }
    }
}
