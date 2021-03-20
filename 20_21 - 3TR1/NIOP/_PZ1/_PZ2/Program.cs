using System;
using System.IO;

namespace _PZ2
{
    class NIOP
    {
        public static Logger log = new Logger();
        public static string fileText = "", fileName = "";

        static void Main()
        {
            Console.Clear();
        clr:
            Console.Write("Izbornik: \n" +
                          "1. Pretvaranje teksta iz datoteke u velika slova\n" +
                          "2. Pretvaranje teksta iz datoteka u mala slova\n" +
                          "3. Kreiranje .cs datoteke\n" +
                          "4. Kreiranje .html datoteke\n" +
                          "0. Izlaz\n\n" +
                          "Vaš odabir: ");

            int userInput;
            if (!int.TryParse(Console.ReadLine(), out userInput))
                userInput = -1; // override the wrong input to go to default in switch case

            Console.Clear();

            switch (userInput)
            {
                case 1:
                    BigLetterDocument();
                    break;
                case 2:
                    SmallLetterDocument();
                    break;
                case 3:
                    CreateHelloWorldCSharp();
                    break;
                case 4:
                    CreateHelloWorldHTML();
                    break;

                // if more cases are needed - add here

                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opcija nije moguća.\n");
                    goto clr;
            }

            Console.ReadLine();
        }

        public static void BackToMenu()
        {
            Console.WriteLine("\nVaša datoteka je kreirana.");
            Console.WriteLine("\nPritisnite Enter kako bi se vratili na početni menu.");
            Console.ReadLine();
            Main();
        }
        public static void LoadFile()
        {
            log.LogText("Inicijaliziranje unosa datoteke.");

            Console.Write("Unesite ime datoteke (npr. loremIpsum.txt) ili 0 za izlaz: ");
            fileName = Console.ReadLine();

            if (fileName == "0") Main();

            bool valid = File.Exists(fileName);

            if (!valid)
            {
                log.LogText("Datoteka ne postoji. Traženje korisnika da unese novu.");
                Console.Clear();
                Console.WriteLine("Datoteka ne postoji. Molimo unesite novu.\n");

                LoadFile();
            }

            log.LogText("Inicijalizacija tekstualne datoteke.");
            using (var stream = new StreamReader(fileName))
            {
                fileText = stream.ReadToEnd();
            }
            log.LogText("Tekst inicijaliziran.");

        }
        public static void CreateHelloWorldCSharp()
        {
            Console.Write("Unesite naziv datoteke (bez ekstenzije): ");
            string file = Console.ReadLine() + ".cs";

            log.LogText("Kreiranje Hello World C# datoteke...");
            using (var stream = new StreamWriter(file))
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

            BackToMenu();
        }
        public static void SmallLetterDocument()
        {
            LoadFile();

            string fileNameX = fileName.Split('.')[0] + "_lower" + ".txt";

            log.LogText("Ispivianje teksta sa malim slovima.");
            using (var stream = new StreamWriter(fileNameX))
            {
                stream.Write(fileText.ToLower());
            }
            log.LogText("Ispis izvršen");

            BackToMenu();
        }
        public static void BigLetterDocument()
        {
            LoadFile();

            string fileNameX = fileName.Split('.')[0] + "_upper" + ".txt";

            log.LogText("Ispisivanje teksta sa velikim slovima.");
            using (var stream = new StreamWriter(fileNameX))
            {
                stream.Write(fileText.ToUpper());
            }
            log.LogText("Ispis izvršen.");

            BackToMenu();
        }
        public static void CreateHelloWorldHTML()
        {
            Console.Write("Unesite naziv datoteke (bez ekstenzije): ");
            string file = Console.ReadLine() + ".html";

            log.LogText("Kreiranje Hello World HTML datoteke...");
            using (var stream = new StreamWriter(file))
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

            BackToMenu();
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