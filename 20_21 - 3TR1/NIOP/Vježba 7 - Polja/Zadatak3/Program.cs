using System;

namespace Zadatak3
{
    class NIOP
    {
        static void Main(string[] args)
        {
            string lipsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin scelerisque, leo a varius elementum, ante elit rutrum magna, non varius massa orci in tortor.Nunc ac turpis at purus gravida posuere.Aenean aliquet, libero nec accumsan venenatis, sapien risus scelerisque turpis, sagittis consectetur metus leo nec nisi.Suspendisse mollis iaculis turpis non pretium. Aenean luctus massa id urna facilisis, eu varius mi accumsan.Vivamus cursus nunc nulla. Aliquam quis posuere ligula. Nulla pulvinar mi at urna lacinia rutrum. Aenean ac diam et nulla pretium elementum.Quisque sapien ex, viverra ac nibh nec, gravida sagittis orci. Aliquam dictum, nisl sed porta.";
            string[] lipsumArr = lipsum.Split(' ');
            foreach (string elem in lipsumArr)
                Console.WriteLine($"{elem} | {elem.Length}");
        }
    }
}
