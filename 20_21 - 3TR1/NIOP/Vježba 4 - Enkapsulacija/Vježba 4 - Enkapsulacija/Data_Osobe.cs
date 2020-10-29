using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba_4___Enkapsulacija
{
    class Data_Osobe
    {
        public static Random r = new Random();

        // Prvih 5 su Učenici, drugih 5 profesori
        public string[] first_name = { "Marko","Boban","Valentino","Delnik","Borat",
                                "Ivan", "Danijela", "Mirko", "Tomislav", "Dinka"};

        public string[] last_name = { "Zvegelj", "Krank", "Mrkšić", "Spornik", "Borat",
                                    "Marušić", "Ižaković", "Mesić", "Rudec", "Šafar-Đerki"};

        public bool razrednik;

        public int razred;
        public int OIB;

        public DateTime dateTime_ucenik;
        public DateTime dateTime_nastavnik;

        private DateTime RandomDayFunc(DateTime start)
        {
            DateTime newDate = new DateTime(1960, 1, 1);

            if (start.Year == 1960)
                newDate = newDate.AddYears(r.Next(0, 30));

            else
                newDate = newDate.AddYears(40 + (6 - razred));

            newDate = newDate.AddMonths(r.Next(1, 12));
            newDate = newDate.AddDays(r.Next(1, 31));

            return newDate;
        }

        public Data_Osobe()
        {
            this.razrednik = Convert.ToBoolean(random(0));
            this.razred = random(1);
            this.OIB = random(2);

            this.dateTime_nastavnik = randomDT(1);
            this.dateTime_ucenik = randomDT(2);
        }

        private int random(int inpt)
        {
            switch (inpt)
            {
                case 0:
                    if (r.Next(1, 1000) > 500) return 0; else return 1;
                case 1:
                    return r.Next(1, 4);

                case 2:
                    return r.Next(1000000000, int.MaxValue);

                default:
                    return 0;
            }
        }

        private DateTime randomDT(int inpt)
        {
            switch (inpt)
            {
                case 1:
                    return RandomDayFunc(new DateTime(1960, 1, 1));

                case 2:
                    return RandomDayFunc(new DateTime(2000, 1, 1));

                default:
                    return new DateTime(0);
            }
        }
    }
}
