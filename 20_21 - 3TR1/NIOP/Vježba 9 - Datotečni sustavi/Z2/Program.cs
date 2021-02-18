using System;
using System.IO;

namespace NIOP
{
    class Z2
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("nums.txt"))
            {
                int cntr = 0;
                for (int i = 1; i <= 1000; ++i)
                {
                    if (i % 2 == 0)
                    {
                        sw.WriteLine(i);
                        ++cntr;
                    }
                }
                sw.WriteLine(cntr);
            }
        }
    }
}
