using System;
using System.IO;

namespace _PZ1
{
    class NIOP
    {
        static void Main(string[] args)
        {
            Logger log = new Logger();
            string fileText = "";

            log.LogText("Inicijalizacija teksta");
            using (var stream = new StreamReader("postojece.txt"))
            {
                fileText = stream.ReadToEnd();
            }
            log.LogText("Tekst inicijaliziran.");

            log.LogText("Ispisivanje teksta sa velikim slovima.");
            using (var stream = new StreamWriter("letters_big.txt"))
            {
                stream.Write(fileText.ToUpper());
            }
            log.LogText("Ispis izvršen.");

            log.LogText("Ispivianje teksta sa malim slovima.");
            using (var stream = new StreamWriter("letters_small.txt"))
            {
                stream.Write(fileText.ToLower());
            }
            log.LogText("Ispis izvršen");

            log.LogText("Kreiranje Hello World C# datoteke...");
            using (var stream = new StreamWriter("PozdravSvite.cs"))
            {
                stream.Write("using System;\n" +
                             "using System;\n\n" +
                             "namespace _PZ1\n" +
                             "{\n" +
                             "\tclass NIOP\n" +
                             "\t{\n" +
                             "\t\tstatic void Main(string[] args)\n" +
                             "\t\t{\n" +
                             "\t\t\tConsole.WriteLine(\"Hello World\");\n" +
                             "\t\t\tConsole.ReadLine();\n" +
                             "\t\t}\n" +
                             "\t}\n" +
                             "}");
            }
            log.LogText("Kreirana Hello World C# datoteka.");

            log.LogText("Kreiranje Hello World HTML datoteke...");
            using (var stream = new StreamWriter("PozdravSvite.html"))
            {
                stream.Write("<!DOCTYPE html>\n" +
                             "<html>\n" +
                             "\t<head>\n" +
                             "\t\t<title>Pozdrav Svite</title>\n" +
                             "\t</head>\n" +
                             "\t<body>\n" +
                             "\t\t<p style=\"text-align: center;\"> Hello world! </p>\n" +
                             "\t</body>\n" +
                             "</html>\n");
            }
            log.LogText("Kreirana Hello World HTML datoteka.");
        }
    }

    public class Logger
    {
        public void LogText(string text)
        {
            string log = $"\n-- MAIN LOG: {DateTime.Now} - {text} --";

            File.AppendAllText("log.txt", log);
        }
    }
}